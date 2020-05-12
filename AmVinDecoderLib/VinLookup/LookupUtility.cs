using System;
using System.Linq;

namespace AmVinDecoderLib.VinLookup
{
    public static class LookupUtility
    {
        internal static string ValidateLetterVinCode(char vinCode)
        {
            if (!char.IsLetter(vinCode))
            {
                throw new ArgumentOutOfRangeException(nameof(vinCode), "Expecting a letter code");
            }

            return vinCode.ToString().ToUpperInvariant();
        }

        internal static string ValidateLetterOrDigitVinCode(string vinCode, int length)
        {
            if (string.IsNullOrWhiteSpace(vinCode))
            {
                throw new ArgumentNullException(nameof(vinCode));
            }

            if (vinCode.Length != length)
            {
                throw new ArgumentOutOfRangeException(nameof(vinCode), $"VIN code is not {length} characters long");
            }

            if (!vinCode.All(Char.IsLetterOrDigit))
            {
                throw new ArgumentOutOfRangeException(nameof(vinCode), "Expecting only letters and digits");
            }

            return vinCode.ToUpperInvariant();
        }
    }
}
