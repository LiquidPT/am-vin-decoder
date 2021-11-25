// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Properties;
using EnsureThat;

namespace AmVinDecoderLib.Utilities;

public static class EnsureThatStringExtensions
{
    public static void IsAlphaNumeric(this in StringParam param)
    {
        if (param.Value.All(char.IsLetterOrDigit))
        {
            return;
        }

        throw new ArgumentOutOfRangeException(param.Name, Resources.Error_OnlyLettersAndDigits);
    }

    public static void IsAlpha(this in StringParam param)
    {
        if (param.Value.All(char.IsLetter))
        {
            return;
        }

        throw new ArgumentOutOfRangeException(param.Name, Resources.Error_OnlyLetters);
    }

    public static void IsNumeric(this in StringParam param)
    {
        if (param.Value.All(char.IsDigit))
        {
            return;
        }

        throw new ArgumentOutOfRangeException(param.Name, Resources.Error_OnlyDigits);
    }

    public static void IsNullOrNumeric(this in StringParam param)
    {
        if (string.IsNullOrEmpty(param.Value))
        {
            return;
        }

        if (param.Value.All(char.IsDigit))
        {
            return;
        }

        throw new ArgumentOutOfRangeException(param.Name, Resources.Error_OnlyDigits);
    }
}
