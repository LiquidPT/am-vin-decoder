// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using AmVinDecoderLib.Properties;
using EnsureThat;

namespace AmVinDecoderLib.Utilities;

public static class EnsureThatValueTypeExtensions
{
    public static void IsAlphaNumeric(this in Param<char> param)
    {
        if (char.IsLetterOrDigit(param.Value))
        {
            return;
        }

        throw new ArgumentOutOfRangeException(param.Name, Resources.Error_OnlyLettersAndDigits);
    }

    public static void IsAlpha(this in Param<char> param)
    {
        if (char.IsLetter(param.Value))
        {
            return;
        }

        throw new ArgumentOutOfRangeException(param.Name, Resources.Error_CharLetter);
    }

    public static void IsNumeric(this in Param<char> param)
    {
        if (char.IsDigit(param.Value))
        {
            return;
        }

        throw new ArgumentOutOfRangeException(param.Name, Resources.Error_CharDigit);
    }

    public static void IsNullOrNumeric(this in Param<char?> param)
    {
        if (!param.Value.HasValue)
        {
            return;
        }

        if (char.IsDigit(param.Value.Value))
        {
            return;
        }

        throw new ArgumentOutOfRangeException(param.Name, Resources.Error_CharDigit);
    }
}
