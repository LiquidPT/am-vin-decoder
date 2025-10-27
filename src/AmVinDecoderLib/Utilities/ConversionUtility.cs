// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Properties;

namespace AmVinDecoderLib.Utilities;

/// <summary>
/// Provides utility methods for converting values between different units of power and torque.
/// </summary>
/// <remarks>This class contains static methods for converting between supported units, such as kilowatts (kW) and
/// brake horsepower (Bhp) for power, and newton-meters (Nm) and pound-feet (LbFt) for torque. All methods return null
/// if the input value is null, and throw a NotImplementedException if the requested conversion is not supported. This
/// class is intended for use in scenarios where unit conversions are required for automotive or engineering
/// calculations.</remarks>
public static class ConversionUtility
{
    private const double HpPerKw = 1.341022;
    private const double LbFtPerNm = 0.737562149;

    /// <summary>
    /// Converts a power value from one unit to another, supporting conversions between kilowatts (kW) and brake
    /// horsepower (Bhp).
    /// </summary>
    /// <remarks>If the source and target units are the same, the original value is returned. The conversion
    /// uses a fixed ratio between kilowatts and brake horsepower. Only conversions between kilowatts and brake
    /// horsepower are supported.</remarks>
    /// <param name="value">The power value to convert. If <see langword="null"/>, the method returns <see langword="null"/>.</param>
    /// <param name="fromUnit">The unit of the input power value. Must be either <see cref="PowerUnit.Kw"/> or <see cref="PowerUnit.Bhp"/>.</param>
    /// <param name="toUnit">The unit to which the power value should be converted. Must be either <see cref="PowerUnit.Kw"/> or <see
    /// cref="PowerUnit.Bhp"/>.</param>
    /// <returns>The converted power value in the specified unit, or <see langword="null"/> if <paramref name="value"/> is <see
    /// langword="null"/>.</returns>
    /// <exception cref="NotImplementedException">Thrown if the conversion between the specified units is not supported.</exception>
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

        if (fromUnit == PowerUnit.Kw && toUnit == PowerUnit.Bhp)
        {
            return Math.Round(value.Value * HpPerKw);
        }

        if (fromUnit == PowerUnit.Bhp && toUnit == PowerUnit.Kw)
        {
            return Math.Round(value.Value / HpPerKw);
        }

        throw new NotImplementedException(Resources.Error_ConversionNotImplemented);
    }

    /// <summary>
    /// Converts a torque value from one unit of measurement to another.
    /// </summary>
    /// <remarks>Supported conversions are between Newton-meters (Nm) and pound-feet (LbFt). If the source and
    /// target units are the same, the original value is returned.</remarks>
    /// <param name="value">The torque value to convert. If <see langword="null"/>, the method returns <see langword="null"/>.</param>
    /// <param name="fromUnit">The unit of the input torque value.</param>
    /// <param name="toUnit">The unit to which the torque value should be converted.</param>
    /// <returns>The converted torque value in the specified unit, or <see langword="null"/> if <paramref name="value"/> is <see
    /// langword="null"/>.</returns>
    /// <exception cref="NotImplementedException">Thrown if the specified unit conversion is not supported.</exception>
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
            return Math.Round(value.Value * LbFtPerNm);
        }

        if (fromUnit == TorqueUnit.LbFt && toUnit == TorqueUnit.Nm)
        {
            return Math.Round(value.Value / LbFtPerNm);
        }

        throw new NotImplementedException(Resources.Error_ConversionNotImplemented);
    }
}
