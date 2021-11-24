// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib;

public record UnitOptions
{
    public bool UseMetric { get; init; }

    public PowerUnit? Power { get; init; }

    public TorqueUnit? Torque { get; init; }
}
