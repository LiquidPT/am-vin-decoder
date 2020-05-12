using AmVinDecoderLib.VinComponents;
using AmVinDecoderLib.VinComponents.Enum;
using System;

namespace AmVinDecoderLib.VinLookup
{
    public class SteeringLookup
    {
        public static Steering Lookup(char vinCode)
        {
            var validatedVinCode = LookupUtility.ValidateLetterVinCode(vinCode);

            return new Steering
            {
                Text = GetText(validatedVinCode)
            };
        }

        private static string GetText(string validatedVinCode)
        {
            switch (validatedVinCode)
            {
                case "A":
                case "C":
                case "E":
                case "J":
                case "L":
                    return SteeringPosition.RHD.ToString();
                case "B":
                case "D":
                case "F":
                case "K":
                case "M":
                    return SteeringPosition.LHD.ToString();
                default: throw new ArgumentException("Unrecognized steering code.");
            }
        }
    }
}
