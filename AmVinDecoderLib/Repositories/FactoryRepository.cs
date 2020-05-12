using AmVinDecoderLib.VinComponents;
using AmVinDecoderLib.Utilities;
using System;

namespace AmVinDecoderLib.Repositories
{
    public class FactoryRepository
    {
        public static Factory Lookup(char vinCode)
        {
            var validatedVinCode = LookupUtility.ValidateLetterVinCode(vinCode);

            return new Factory
            {
                Text = GetText(validatedVinCode)
            };
        }

        private static string GetText(string validatedVinCode)
        {
            switch (validatedVinCode)
            {
                case "A": return "Austria, Magna Steyr";
                case "G": return "Gaydon";
                default: throw new ArgumentException("Unrecognized factory code.");
            }
        }
    }
}
