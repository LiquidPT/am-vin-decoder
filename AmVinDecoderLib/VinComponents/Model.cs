// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.VinComponents.Enum;

namespace AmVinDecoderLib.VinComponents
{
    public class Model : BaseVinComponent
    {
        public ModelType ModelType { get; set; }

        public bool IsV12VantageS { get; set; }

        public bool IsDb11Volante { get; set; }

        public bool IsNgDbs { get; set; }
    }
}
