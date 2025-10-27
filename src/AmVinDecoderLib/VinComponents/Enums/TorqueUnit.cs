// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.VinComponents.Enums;

/// <summary>
/// Specifies the units of measurement for torque values.
/// </summary>
/// <remarks>Use this enumeration to indicate the unit in which a torque value is expressed, such as pound-feet or
/// newton-metres. The <see cref="TorqueUnit.Unknown"/> value represents an unset or unspecified unit and should not be
/// used for calculations.</remarks>
public enum TorqueUnit
{
    /// <summary>
    /// Default value. The value has not been set.
    /// </summary>
    Unknown,

    /// <summary>
    /// lb-ft, pound feet
    /// </summary>
    LbFt,

    /// <summary>
    /// N⋅m, newton metres
    /// </summary>
    Nm,
}
