// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.VinComponents.Enums
{
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
}
