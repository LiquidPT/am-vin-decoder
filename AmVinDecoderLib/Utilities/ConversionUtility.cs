// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using AmVinDecoderLib.VinComponents.Enum;

namespace AmVinDecoderLib.Utilities
{
    public static class ConversionUtility
    {
        private const double HpPerKw = 1.341022;
        private const double LbFtPerNm = 0.737562149;

        public static double? ConvertPower(double? value, PowerUnit fromUnit, PowerUnit toUnit)
        {
            if (!value.HasValue)
            {
                return null;
            }

            if (fromUnit == toUnit)
            {
                return value;
            }

            if (fromUnit == PowerUnit.Kw && toUnit == PowerUnit.Hp)
            {
                return Math.Round(value.Value * HpPerKw, 2);
            }

            if (fromUnit == PowerUnit.Hp && toUnit == PowerUnit.Kw)
            {
                return Math.Round(value.Value / HpPerKw, 2);
            }

            throw new NotImplementedException("No conversion implemented for these units.");
        }

        public static double? ConvertTorque(double? value, TorqueUnit fromUnit, TorqueUnit toUnit)
        {
            if (!value.HasValue)
            {
                return null;
            }

            if (fromUnit == toUnit)
            {
                return value;
            }

            if (fromUnit == TorqueUnit.Nm && toUnit == TorqueUnit.LbFt)
            {
                return Math.Round(value.Value * LbFtPerNm, 2);
            }

            if (fromUnit == TorqueUnit.LbFt && toUnit == TorqueUnit.Nm)
            {
                return Math.Round(value.Value / LbFtPerNm, 2);
            }

            throw new NotImplementedException("No conversion implemented for these units.");
        }
    }
}
