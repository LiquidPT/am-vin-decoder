// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.Linq;

namespace AmVinDecoderLib.Utilities
{
    public static class LookupUtility
    {
        public static string ValidateLetterVinCode(char vinCode)
        {
            if (!char.IsLetter(vinCode))
            {
                throw new ArgumentOutOfRangeException(nameof(vinCode), "Expecting a letter code");
            }

            return vinCode.ToString().ToUpperInvariant();
        }

        public static string ValidateLetterOrDigitVinCode(char vinCode)
        {
            if (!char.IsLetterOrDigit(vinCode))
            {
                throw new ArgumentOutOfRangeException(nameof(vinCode), "Expecting a letter or digit code");
            }

            return vinCode.ToString().ToUpperInvariant();
        }

        public static string ValidateLetterOrDigitVinCode(string vinCode, int length)
        {
            if (string.IsNullOrWhiteSpace(vinCode))
            {
                throw new ArgumentNullException(nameof(vinCode));
            }

            if (vinCode.Length != length)
            {
                throw new ArgumentOutOfRangeException(nameof(vinCode), $"VIN code is not {length} characters long");
            }

            if (!vinCode.All(char.IsLetterOrDigit))
            {
                throw new ArgumentOutOfRangeException(nameof(vinCode), "Expecting only letters and digits");
            }

            return vinCode.ToUpperInvariant();
        }
    }
}
