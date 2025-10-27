// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.VinComponents;

/// <summary>
/// Represents detailed information about an engine, including its configuration, induction type, displacement, and
/// performance specifications.
/// </summary>
/// <remarks>This record provides a structured representation of engine attributes commonly used in vehicle
/// identification and specification systems. It includes properties for engine code, cylinder count, induction method,
/// displacement, and maximum power and torque values with their respective units and RPMs. All properties are immutable
/// except for maximum power and torque values and their units, which can be set after initialization. This type is
/// intended for use in scenarios where precise engine data is required, such as automotive data processing, VIN
/// decoding, or vehicle specification management.</remarks>
public record Engine : BaseVinComponent
{
    /// <summary>
    /// Gets the code associated with this instance.
    /// </summary>
    public string Code { get; init; }

    /// <summary>
    /// Gets the number of cylinders in the engine.
    /// </summary>
    public int Cylinders { get; init; }

    /// <summary>
    /// Gets the induction settings associated with this instance.
    /// </summary>
    public Induction Induction { get; init; }

    /// <summary>
    /// Gets the engine displacement in cubic centimeters (cc).
    /// </summary>
    public double DisplacementInCc { get; init; }

    /// <summary>
    /// Gets or sets the maximum allowable power value.
    /// </summary>
    public double? MaxPower { get; set; }

    /// <summary>
    /// Gets or sets the maximum allowable power unit for the operation.
    /// </summary>
    public PowerUnit MaxPowerUnit { get; set; }

    /// <summary>
    /// Gets the engine speed, in revolutions per minute (RPM), at which maximum power is produced.
    /// </summary>
    public double? MaxPowerRpm { get; init; }

    /// <summary>
    /// Gets or sets the maximum torque value that can be applied.
    /// </summary>
    public double? MaxTorque { get; set; }

    /// <summary>
    /// Gets or sets the unit of measurement used to represent the maximum torque value.
    /// </summary>
    public TorqueUnit MaxTorqueUnit { get; set; }

    /// <summary>
    /// Gets the engine speed, in revolutions per minute (RPM), at which the maximum torque is produced.
    /// </summary>
    public double? MaxTorqueRpm { get; init; }
}
