// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.VinComponents.Enums
{
    public enum SeatingConfiguration
    {
        /// <summary>
        /// Default value. The value has not been set.
        /// </summary>
        Unknown,

        /// <summary>
        /// 2 front seats with 2 small back seats
        /// </summary>
        TwoPlusTwo,

        /// <summary>
        /// 2 front seats with package storage where there is normally small back seats
        /// </summary>
        TwoPlusZero,

        /// <summary>
        /// Can be configured with either 2+2 or 2+0
        /// </summary>
        TwoPlusUnknown,

        /// <summary>
        /// A 2 seat configuration with no option for back seats
        /// </summary>
        TwoSeats,

        /// <summary>
        /// 4 full sized seats
        /// </summary>
        FourSeats,

        /// <summary>
        /// 5 full sized seats
        /// </summary>
        FiveSeats,
    }
}
