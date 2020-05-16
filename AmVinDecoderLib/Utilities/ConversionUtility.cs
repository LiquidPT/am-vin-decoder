// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;

namespace AmVinDecoderLib.Utilities
{
    public static class ConversionUtility
    {
        public static double? PowerInKwToHp(double? powerInHp)
        {
            if (!powerInHp.HasValue)
            {
                return null;
            }

            return Math.Round(powerInHp.Value * 1.341022, 2);
        }

        public static double? TorqueInNmToLbFt(double? torqueInNm)
        {
            if (!torqueInNm.HasValue)
            {
                return null;
            }

            return Math.Round(torqueInNm.Value * 0.737562149, 2);
        }
    }
}
