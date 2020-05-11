using System;
using System.Linq;

namespace AmVinDecoderLib.VinComponents
{
    public class Seating : BaseVinComponent
    {
        private const string twoPlusTwo = "2+2";
        private const string twoPlusZero = "2+0";
        private const string twoPlusUnknown = "2+0 or 2+2";
        private const string twoSeats = "2 seats";
        private const string fourSeats = "4 seats";
        private new readonly string _vinCode;

        public Seating(string vinCode)
        {
            if (string.IsNullOrWhiteSpace(vinCode))
            {
                throw new ArgumentNullException(nameof(vinCode));
            }

            if (vinCode.Length != 2)
            {
                throw new ArgumentOutOfRangeException(nameof(vinCode), "VIN code is not 2 characters long");
            }

            if (!vinCode.All(Char.IsLetterOrDigit))
            {
                throw new ArgumentOutOfRangeException(nameof(vinCode), "Expecting only letters and digits");
            }

            _vinCode = vinCode.ToUpperInvariant();
        }

        protected override string GetText()
        {
            switch (_vinCode)
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
