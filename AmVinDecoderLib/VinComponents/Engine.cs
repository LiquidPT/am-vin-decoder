// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.VinComponents.Enum;

namespace AmVinDecoderLib.VinComponents
{
    public class Engine : BaseVinComponent
    {
        public int Cylinders { get; set; }

        public Induction Induction { get; set; }

        public decimal Displacement { get; set; }

        public decimal Power { get; set; }

        public decimal Torque { get; set; }
    }
}
