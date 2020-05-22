// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using EnsureThat;

namespace AmVinDecoderLib.Utilities
{
    public static class LookupUtility
    {
        public static string ValidateLetterVinCode(char vinCode)
        {
            Ensure.That<char>(vinCode, nameof(vinCode)).IsAlpha();

            return vinCode.ToString().ToUpperInvariant();
        }

        public static string ValidateLetterOrDigitVinCode(string vinCode, int length)
        {
            Ensure.That(vinCode, nameof(vinCode)).SizeIs(length);
            Ensure.That(vinCode, nameof(vinCode)).IsAlphaNumeric();

            return vinCode.ToUpperInvariant();
        }
    }
}
