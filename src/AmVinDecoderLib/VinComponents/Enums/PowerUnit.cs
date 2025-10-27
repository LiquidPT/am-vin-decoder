// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.VinComponents.Enums;

/// <summary>
/// Specifies the units of measurement for power values, such as brake horsepower or kilowatts.
/// </summary>
/// <remarks>Use this enumeration to indicate the unit in which a power value is expressed. The value may be used
/// for display, conversion, or validation purposes in applications that handle power measurements.</remarks>
public enum PowerUnit
{
    /// <summary>
    /// Default value. The value has not been set.
    /// </summary>
    Unknown,

    /// <summary>
    /// BHP, brake horsepower
    /// </summary>
    Bhp,

    /// <summary>
    /// KW, kilowatts
    /// </summary>
    Kw,
}
