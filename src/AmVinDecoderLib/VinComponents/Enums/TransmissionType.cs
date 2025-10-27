// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.VinComponents.Enums;

/// <summary>
/// Specifies the type of transmission used in a vehicle.
/// </summary>
/// <remarks>Use this enumeration to indicate whether a vehicle has an automatic, manual, or automated manual
/// transmission. The value <see cref="TransmissionType.Unknown"/> represents an unset or unspecified transmission
/// type.</remarks>
public enum TransmissionType
{
    /// <summary>
    /// Default value. The value has not been set.
    /// </summary>
    Unknown,

    /// <summary>
    /// Traditional automatic transmission with a torque converter
    /// </summary>
    Automatic,

    /// <summary>
    /// Manually shifted transmission with a clutch pedal
    /// </summary>
    Manual,

    /// <summary>
    /// Manual transmission with paddles
    /// </summary>
    AutomatedManual,
}
