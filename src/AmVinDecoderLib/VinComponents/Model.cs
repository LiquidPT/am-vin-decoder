// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.VinComponents;

/// <summary>
/// Represents a vehicle model and its associated type information.
/// </summary>
public record Model : BaseVinComponent
{
    /// <summary>
    /// Gets the type of model represented by this instance.
    /// </summary>
    public ModelType ModelType { get; init; }
}
