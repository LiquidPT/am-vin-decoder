// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib;

/// <summary>
/// Represents configuration options for specifying measurement units used in calculations or data representation.
/// </summary>
/// <remarks>Use this type to define whether metric units are preferred and to specify the units for power and
/// torque measurements. This record is typically used to standardize unit selection across related operations or
/// components.</remarks>
public record UnitOptions
{
    /// <summary>
    /// Gets a value indicating whether metric units are used for measurements.
    /// </summary>
    public bool UseMetric { get; init; }

    /// <summary>
    /// Gets the power unit of measurement.
    /// </summary>
    public PowerUnit? Power { get; init; }

    /// <summary>
    /// Gets the torque value associated with the object, expressed in the specified unit if available.
    /// </summary>
    public TorqueUnit? Torque { get; init; }
}
