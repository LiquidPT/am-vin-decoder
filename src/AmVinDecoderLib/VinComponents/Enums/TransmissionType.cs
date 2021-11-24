// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.VinComponents.Enums;

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
