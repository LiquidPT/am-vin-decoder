using AmVinDecoderLib.VinComponents;
using AmVinDecoderLib.Utilities;
using System;

namespace AmVinDecoderLib.Repositories
{
    public class ModelRepository
    {
        public static Model Lookup(char vinCode, char? serialModifer)
        {
            var validatedVinCode = LookupUtility.ValidateLetterVinCode(vinCode);

            if (serialModifer.HasValue && !char.IsDigit(serialModifer.Value))
            {
                throw new ArgumentOutOfRangeException(nameof(serialModifer), "Expecting a digit");
            }

            return new Model
            {
                Text = GetText(validatedVinCode, serialModifer.GetValueOrDefault()),
                IsV12VantageS = IsV12VantageS(validatedVinCode, serialModifer.GetValueOrDefault())
            };
        }

        private static bool IsV12VantageS(string validatedVinCode, char serialmodifier)
        {
            if (!validatedVinCode.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            var sMod = serialmodifier;
            if (sMod == '0' || sMod == '2')
            {
                return true;
            }

            return false;
        }

        private static string GetText(string validatedVinCode, char serialmodifier)
        {
            switch (validatedVinCode)
            {
                case "A": return "DB9 Coupe";
                case "B": return "DB9 Volante";
                case "C": return "V8/V8S Coupe";
                case "D": return "V8/V8S Roadster";
                case "E":
                    {
                        switch (serialmodifier)
                        {
                            case '0': return "DBS Coupe";
                            case '1': return "DBS Volante";
                            default: return "DBS";
                        }
                    }
                case "F": return "Rapide";
                case "G": return "Virage Coupe";
                case "H": return "Virage Volante";
                case "J":
                    {
                        switch (serialmodifier)
                        {
                            case '3': return "Vanquish Zagato Coupe";
                            default: return "Vanquish Coupe";
                        }
                    }
                case "K": return "Vanquish Volante";
                case "L": return "DB11 Coupe";
                case "M": return "DB11 Volante";
                case "N": return "New Vantage Coupe";
                case "R": return "New DBS Coupe";
                case "S":
                    {
                        switch (serialmodifier)
                        {
                            case '0': return "V12 Vantage S Coupe";
                            case '1': return "V12 Vantage Roadster";
                            case '2': return "V12 Vantage S Roadster";
                            default: return "V12 Vantage Coupe";
                        }
                    }
                default: throw new ArgumentException("Unrecognized model code.");
            }
        }
    }
}
