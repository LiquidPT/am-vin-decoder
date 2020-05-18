// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;

namespace AmVinDecoderLib.VinComponents
{
    public class Transmission : BaseVinComponent
    {
        public bool HasClutchPedal { get; set; }

        public bool HasTorqueConverter { get; set; }

        public int ForwardSpeeds { get; set; }

        public override string ToString(IFormatProvider provider)
        {
            if (HasClutchPedal)
            {
                return string.Format(provider, "{0} speed manual", ForwardSpeeds);
            }

            if (HasTorqueConverter)
            {
                return string.Format(provider, "{0} speed auto", ForwardSpeeds);
            }

            return string.Format(provider, "{0} {1} speed automated manual", Text, ForwardSpeeds);
        }
    }
}
