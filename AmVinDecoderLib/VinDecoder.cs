// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using AmVinDecoderLib.Repositories;
using AmVinDecoderLib.VinComponents.Enum;
using EnsureThat;

namespace AmVinDecoderLib
{
    public static class VinDecoder
    {
        public static VehicleSummary GetVehicleInfo(string vin, UnitOptions unitOptions)
        {
            Ensure.That(vin, nameof(vin)).IsNotNullOrWhiteSpace();
            Ensure.That(unitOptions, nameof(unitOptions)).IsNotNull();
            Ensure.That(vin, nameof(vin), opts => opts.WithMessage("VIN is not 17 characters long")).SizeIs(17);

            var wmi = vin.Substring(VinPosition.Wmi, 3);
            Ensure.That(wmi, nameof(vin), opts => opts.WithMessage("Not an Aston Martin VIN")).StartsWith("SCF", StringComparison.OrdinalIgnoreCase);

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

            info.Engine = EngineRepository.Lookup(vin[VinPosition.Engine], powerUnits, torqueUnits, info.Model.ModelType);
            info.RestraintSystem = RestraintSystemRepository.Lookup(vin[VinPosition.Restraint], info.ModelYear.Text, info.Model.ModelType);
            info.Transmisson = TransmissionRepository.Lookup(vin[VinPosition.Transmission], info.Model.ModelType);

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
