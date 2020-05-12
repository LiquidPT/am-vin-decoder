using AmVinDecoderLib.VinComponents;
using AmVinDecoderLib.Utilities;
using System;

namespace AmVinDecoderLib.Repositories
{
    public class SeatingRepository
    {
        private const string twoPlusTwo = "2+2";
        private const string twoPlusZero = "2+0";
        private const string twoPlusUnknown = "2+0 or 2+2";
        private const string twoSeats = "2 seats";
        private const string fourSeats = "4 seats";

        public static Seating Lookup(string vinCode)
        {
            var validatedVinCode = LookupUtility.ValidateLetterOrDigitVinCode(vinCode, 2);

            return new Seating
            {
                Text = GetText(validatedVinCode)
            };
        }

        private static string GetText(string validatedVinCode)
        {
            switch (validatedVinCode)
            {
                case "01": 
                case "02": 
                case "AA": 
                case "AB": 
                case "AE":
                case "AF": 
                case "CB":
                case "CC":
                case "CF":
                case "CG":
                case "CK":
                case "CL":
                case "EC":
                case "ED":
                case "FA":
                case "FC":
                case "HA":
                    return twoPlusTwo;

                case "03": 
                case "04": 
                case "AC": 
                case "AD": 
                case "AG":
                case "AH": 
                case "CA":
                case "CE":
                case "CH":
                case "CJ":
                case "CM":
                case "EA":
                case "EB":
                    return twoPlusZero;

                case "05": 
                case "CP": 
                case "CR": 
                    return twoPlusUnknown; 
                    
                case "BA": 
                case "BB":
                case "BC": 
                case "BD":
                case "BE": 
                case "BF": 
                case "BN": 
                case "BP":
                case "GA": 
                    return twoSeats; 
                    
                case "DA": 
                case "DE": 
                case "DF": 
                    return fourSeats; 

                default: throw new ArgumentException("Unrecognized body type code.");
            }
        }

    }
}
