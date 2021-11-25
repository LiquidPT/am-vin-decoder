// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.VinComponents;

namespace AmVinDecoderLib;

public record VehicleSummary
{
    public BodyType BodyType { get; init; }

    public Engine Engine { get; internal set; }

    public Factory Factory { get; init; }

    public Model Model { get; init; }

    public ModelYear ModelYear { get; init; }

    public RestraintSystem RestraintSystem { get; internal set; }

    public Transmission Transmisson { get; internal set; }

    public string SerialNumber { get; init; }

    public string Vin { get; init; }
}
