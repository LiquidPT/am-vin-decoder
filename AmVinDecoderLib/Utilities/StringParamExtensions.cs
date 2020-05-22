// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.Linq;
using EnsureThat;

namespace AmVinDecoderLib.Utilities
{
    public static class StringParamExtensions
    {
        public static void IsAlphaNumeric(this in StringParam param)
        {
            if (param.Value.All(char.IsLetterOrDigit))
            {
                return;
            }

            throw new ArgumentOutOfRangeException(param.Name, "Expecting only letters and digits");
        }

        public static void IsAlpha(this in StringParam param)
        {
            if (param.Value.All(char.IsLetter))
            {
                return;
            }

            throw new ArgumentOutOfRangeException(param.Name, "Expecting only letters");
        }

        public static void IsNumeric(this in StringParam param)
        {
            if (param.Value.All(char.IsDigit))
            {
                return;
            }

            throw new ArgumentOutOfRangeException(param.Name, "Expecting only digits");
        }
    }
}
