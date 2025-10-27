// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.VinComponents.Enums;

/// <summary>
/// Specifies the steering wheel position for a vehicle, indicating whether it is configured for left-hand drive,
/// right-hand drive, or is unspecified.
/// </summary>
/// <remarks>Use this enumeration to identify or set the steering configuration of a vehicle. The value is
/// typically determined by regional driving conventions and may affect compatibility with certain markets or
/// regulations.</remarks>
public enum SteeringPosition
{
    /// <summary>
    /// Default value. The value has not been set.
    /// </summary>
    Unknown,

    /// <summary>
    /// Left hand drive
    /// </summary>
    LHD,

    /// <summary>
    /// Right hand drive
    /// </summary>
    RHD,
}
