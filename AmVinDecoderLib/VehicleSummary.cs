// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.VinComponents;

namespace AmVinDecoderLib
{
    public class VehicleSummary
    {
        public BodyType BodyType { get; internal set; }

        public Engine Engine { get; internal set; }

        public Factory Factory { get; internal set; }

        public Model Model { get; internal set; }

        public ModelYear ModelYear { get; internal set; }

        public RestraintSystem RestraintSystem { get; internal set; }

        public Seating Seating { get; internal set; }

        public Steering SteeringPosition { get; internal set; }

        public Transmission Transmisson { get; internal set; }

        public string SerialNumber { get; internal set; }

        public string Vin { get; internal set; }
    }
}
