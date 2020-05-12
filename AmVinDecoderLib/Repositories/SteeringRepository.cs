using AmVinDecoderLib.VinComponents;
using AmVinDecoderLib.VinComponents.Enum;
using AmVinDecoderLib.Utilities;
using System;

namespace AmVinDecoderLib.Repositories
{
    public class SteeringRepository
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
