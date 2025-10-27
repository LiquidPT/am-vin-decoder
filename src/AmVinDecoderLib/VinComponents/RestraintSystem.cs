// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.VinComponents;

/// <summary>
/// Represents the restraint system information for a vehicle, as decoded from its VIN data.
/// </summary>
/// <remarks>This record provides details about the vehicle's safety restraint system, such as airbags and
/// seatbelt configurations, as part of VIN component analysis. Use this type to access or represent restraint system
/// attributes when working with vehicle identification data.</remarks>
public record RestraintSystem : BaseVinComponent
{
}
