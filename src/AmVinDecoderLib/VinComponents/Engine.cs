// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.VinComponents;

public record Engine : BaseVinComponent
{
    public string Code { get; init; }

    public int Cylinders { get; init; }

    public Induction Induction { get; init; }

    public double DisplacementInCc { get; init; }

    public double? MaxPower { get; set; }

    public PowerUnit MaxPowerUnit { get; set; }

    public double? MaxPowerRpm { get; init; }

    public double? MaxTorque { get; set; }

    public TorqueUnit MaxTorqueUnit { get; set; }

    public double? MaxTorqueRpm { get; init; }
}
