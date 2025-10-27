// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.VinComponents.Enums;

/// <summary>
/// Specifies the type of engine induction system used to deliver air to the engine.
/// </summary>
/// <remarks>This enumeration distinguishes between engines with no forced induction, engines equipped with a
/// turbocharger, and cases where the induction type is unspecified. Use this type to indicate the method by which
/// intake air is supplied or compressed in an engine configuration.</remarks>
public enum Induction
{
    /// <summary>
    /// Default value. The value has not been set.
    /// </summary>
    Unknown,

    /// <summary>
    /// NormallyAspirated: no forced induction
    /// </summary>
    NormallyAspirated,

    /// <summary>
    /// TurboCharged: uses a turbo to compress intake air
    /// </summary>
    TurboCharged,
}
