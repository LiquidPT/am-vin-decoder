using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;
using System;

namespace AmVinDecoderLib.Repositories
{
    public class TransmissionRepository
    {
        public static Transmission Lookup(char vinCode, bool isV12VantageS = false)
        {
            var validatedVinCode = LookupUtility.ValidateLetterVinCode(vinCode);

            return new Transmission
            {
                Text = GetText(validatedVinCode, isV12VantageS)
            };
        }

        private static string GetText(string validatedVinCode, bool isV12VantageS)
        {
            switch (validatedVinCode)
            {
                case "A":
                case "B":
                    return "Manual";
                case "C":
                case "D":
                    return "Auto";
                case "E":
                case "F":
                    return "Sportshift";
                case "J":
                case "K":
                    return isV12VantageS ? "Sportshift III" : "Sportshift II";
                case "L":
                case "M":
                    return "8-speed Auto";
                default: throw new ArgumentException("Unrecognized transmission code.");
            }
        }
    }
}
