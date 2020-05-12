using AmVinDecoderLib.VinComponents;
using System;

namespace AmVinDecoderLib.VinLookup
{
    public class FactoryLookup
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
