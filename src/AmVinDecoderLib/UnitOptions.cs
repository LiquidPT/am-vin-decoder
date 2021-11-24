// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib
{
    public class UnitOptions
    {
        public bool UseMetric { get; set; }

        public PowerUnit? Power { get; set; }

        public TorqueUnit? Torque { get; set; }
    }
}
