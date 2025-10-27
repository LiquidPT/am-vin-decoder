// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.VinComponents.Enums;

/// <summary>
/// Specifies the available body styles for a vehicle.
/// </summary>
/// <remarks>Use this enumeration to indicate the general configuration of a vehicle's exterior, such as coupe,
/// sedan, or SUV. The values correspond to common automotive body styles and may be used for filtering, display, or
/// categorization purposes. The <see cref="BodyStyle.Unknown"/> value represents an unset or unspecified body
/// style.</remarks>
public enum BodyStyle
{
    /// <summary>
    /// Default value. The value has not been set.
    /// </summary>
    Unknown,

    /// <summary>
    /// Coupe: a hardtop car with 2 doors and a trunk
    /// </summary>
    Coupe,

    /// <summary>
    /// Convertible: a car with a retractable top
    /// </summary>
    Convertible,

    /// <summary>
    /// Sedan: a hardtop car with 4 doors
    /// </summary>
    Sedan,

    /// <summary>
    /// Hatchback: a hardtop car with 2 doors and a liftgate that opens to the passenger compartment
    /// </summary>
    Hatchback,

    /// <summary>
    /// SUV
    /// </summary>
    Suv,
}
