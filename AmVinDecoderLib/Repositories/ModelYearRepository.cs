using AmVinDecoderLib.VinComponents;
using System;

namespace AmVinDecoderLib.Repositories
{
    public class ModelYearRepository
    {
        public static ModelYear Lookup(char vinCode)
        {
            if (!char.IsLetterOrDigit(vinCode))
            {
                throw new ArgumentOutOfRangeException(nameof(vinCode), "Expecting a letter or digit");
            }

            return new ModelYear
            {
                Text = GetText(vinCode)
            };
        }

        private static string GetText(char vinCode)
        {
            int digit = (int)char.GetNumericValue(vinCode);
            if (digit > -1)
            {
                return (2000 + digit).ToString();
            }

            if (char.IsLetter(vinCode))
            {
                int index = char.ToUpper(vinCode) - 65;
                return (index + 2010).ToString();
            }

            throw new ArgumentException("Unrecognized model year code.");
        }
    }
}
