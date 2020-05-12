using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;
using System;

namespace AmVinDecoderLib.Repositories
{
    public class BodyTypeRepository
    {
        public static BodyType Lookup(string vinCode)
        {
            var validatedVinCode = LookupUtility.ValidateLetterOrDigitVinCode(vinCode, 2);

            return new BodyType
            {
                Text = GetText(validatedVinCode)
            };
        }

        private static string GetText(string validatedVinCode)
        {
            switch (validatedVinCode)
            {
                case "01":
                case "03":
                    return "Coupe";
                case "02":
                case "04":
                    return "Convertible";
                case "05":
                    return "DBS";
                case "AA":
                case "AC":
                    return "DB9 Coupe";
                case "AB":
                case "AD":
                    return "DB9 Convertible";
                case "AE":
                case "AG":
                    return "DB9 Coupe";
                case "AF":
                case "AH":
                    return "DB9 Convertible";
                case "BA":
                    return "Vantage coupe";
                case "BB":
                    return "Vantage roadster";
                case "BC":
                    return "V12 Vantage/S coupe";
                case "BD":
                    return "Vantage S coupe";
                case "BE":
                    return "Vantage S convertible";
                case "BF":
                    return "V12 Vantage/S convertible";
                case "BN":
                    return "V12VS w/ sports+ pack coupe";
                case "BP":
                    return "V12VS w/ sports+ pack convertible";
                case "CA":
                case "CB":
                    return "DBS Coupe";
                case "CC":
                    return "DBS convertible";
                case "CE":
                case "CF":
                    return "Vanquish coupe";
                case "CG":
                case "CH":
                    return "Vanquish convertible";
                case "CJ":
                case "CK":
                    return "Vanquish S coupe";
                case "CL":
                case "CM":
                    return "Vanquish S convertible";
                case "CP":
                    return "Vanquish Zagato coupe";
                case "CR":
                    return "Vanquish Zagato convertible";
                case "DA":
                    return "Rapide";
                case "DE":
                    return "Rapide S";
                case "DF":
                    return "Rapide Shadow Ed";
                case "EA":
                case "EC":
                    return "Virage coupe";
                case "EB":
                case "ED":
                    return "Virage convertible";
                case "FA":
                    return "DB11 coupe";
                case "FC":
                    return "DB11 convertible";
                case "GA":
                    return "New Vantage";
                case "HA":
                    return "New DBS Coupe";
                default: throw new ArgumentException("Unrecognized body type code.");
            }
        }

    }
}
