// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.Utilities;

public static class LookupUtility
{
    public static string ValidateLetterVinCode(char vinCode)
    {
        ArgumentOutOfRangeException.ThrowIfNotAlpha(vinCode);

        return vinCode.ToString().ToUpperInvariant();
    }

    public static string ValidateLetterOrDigitVinCode(char vinCode)
    {
        ArgumentOutOfRangeException.ThrowIfNotAlphaNumeric(vinCode);

        return vinCode.ToString().ToUpperInvariant();
    }

    public static string ValidateLetterOrDigitVinCode(string vinCode, int length, bool allowNull = false)
    {
        if (allowNull && string.IsNullOrEmpty(vinCode))
        {
            return null;
        }

        ArgumentException.ThrowIfNullOrWhiteSpace(vinCode);
        ArgumentException.ThrowIfNotLength(vinCode, length);
        ArgumentOutOfRangeException.ThrowIfNotAlphaNumeric(vinCode);

        return vinCode.ToUpperInvariant();
    }
}
