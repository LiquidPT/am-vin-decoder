// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.Globalization;
using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;
using EnsureThat;

namespace AmVinDecoderLib.Repositories
{
    public static class ModelYearRepository
    {
        public static ModelYear Lookup(char vinCode)
        {
            Ensure.That<char>(vinCode, nameof(vinCode)).IsAlphaNumeric();

            return new ModelYear
            {
                Text = GetText(vinCode),
            };
        }

        private static string GetText(char vinCode)
        {
            int digit = (int)char.GetNumericValue(vinCode);
            if (digit > -1)
            {
                return (2000 + digit).ToString(CultureInfo.InvariantCulture);
            }

            if (char.IsLetter(vinCode))
            {
                int index = char.ToUpper(vinCode, CultureInfo.InvariantCulture) - 65;
                if (index >= 9)
                {
                    // The letter "I" was skipped
                    index -= 1;
                }

                return (index + 2010).ToString(CultureInfo.InvariantCulture);
            }

            throw new ArgumentException("Unrecognized model year code.");
        }
    }
}
