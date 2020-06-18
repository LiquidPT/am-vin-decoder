// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.VinComponents.Enums;

namespace AmVinDecoderLib.VinComponents
{
    public class BodyType : BaseVinComponent
    {
        public int DoorCount { get; set; }

        public BodyStyle BodyStyle { get; set; }
    }
}
