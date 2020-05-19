// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using AmVinDecoderLib.Repositories;
using AmVinDecoderLib.VinComponents.Enum;

namespace AmVinDecoderLib
{
    public static class VinDecoder
    {
        public static VehicleSummary GetVehicleInfo(string vin, UnitOptions unitOptions)
        {
            if (string.IsNullOrWhiteSpace(vin))
            {
                throw new ArgumentNullException(nameof(vin));
            }

            if (unitOptions == null)
            {
                throw new ArgumentNullException(nameof(unitOptions));
            }

            if (vin.Length != 17)
            {
                throw new ArgumentOutOfRangeException(nameof(vin), "VIN is not 17 characters long");
            }

            var wmi = vin.Substring(VinPosition.Wmi, 3);
            if (!wmi.Equals("SCF", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentOutOfRangeException(nameof(vin), "Not an Aston Martin VIN");
            }

            var powerUnits = unitOptions.Power ?? (unitOptions.UseMetric ? PowerUnit.Kw : PowerUnit.Bhp);
            var torqueUnits = unitOptions.Torque ?? (unitOptions.UseMetric ? TorqueUnit.Nm : TorqueUnit.LbFt);

            var info = new VehicleSummary
            {
                Vin = vin,
                Factory = FactoryRepository.Lookup(vin[VinPosition.Factory]),
                ModelYear = ModelYearRepository.Lookup(vin[VinPosition.ModelYear]),
                Model = ModelRepository.Lookup(vin[VinPosition.Model], vin[VinPosition.SerialNumber]),
                SteeringPosition = SteeringRepository.Lookup(vin[VinPosition.Transmission]),
                BodyType = BodyTypeRepository.Lookup(vin.Substring(VinPosition.BodyType, 2)),
                Seating = SeatingRepository.Lookup(vin.Substring(VinPosition.BodyType, 2)),
                SerialNumber = vin.Substring(VinPosition.SerialNumber, 5),
            };

            info.Engine = EngineRepository.Lookup(vin[VinPosition.Engine], powerUnits, torqueUnits, info.Model.IsNgDbs);
            info.RestraintSystem = RestraintSystemRepository.Lookup(vin[VinPosition.Restraint], info.ModelYear.Text, info.Model.IsDb11Volante);
            info.Transmisson = TransmissionRepository.Lookup(vin[VinPosition.Transmission], info.Model.IsV12VantageS);

            return info;
        }

        private class VinPosition
        {
            internal const int Wmi = 0;
            internal const int Restraint = 3;
            internal const int Transmission = 4;
            internal const int BodyType = 5;
            internal const int Engine = 7;
            internal const int ModelYear = 9;
            internal const int Factory = 10;
            internal const int Model = 11;
            internal const int SerialNumber = 12;
        }
    }
}
