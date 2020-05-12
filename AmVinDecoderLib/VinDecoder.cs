using AmVinDecoderLib.Repositories;
using System;

namespace AmVinDecoderLib
{
    public static class VinDecoder
    {
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

        public static VehicleSummary GetVehicleInfo(string vin)
        {
            if (string.IsNullOrWhiteSpace(vin))
            {
                throw new ArgumentNullException(nameof(vin));
            }

            if (vin.Length != 17)
            {
                throw new ArgumentOutOfRangeException(nameof(vin), "VIN is not 17 characters long");
            }

            var wmi = vin.Substring(VinPosition.Wmi, 3);
            if (!wmi.Equals("SCF", StringComparison.OrdinalIgnoreCase)) // Aston Martin
            {
                throw new ArgumentOutOfRangeException(nameof(vin), "Not an Aston Martin VIN");
            }

            var info = new VehicleSummary
            {
                Vin = vin,
                Factory = FactoryRepository.Lookup(vin[VinPosition.Factory]),
                ModelYear = ModelYearRepository.Lookup(vin[VinPosition.ModelYear]),
                Model = ModelRepository.Lookup(vin[VinPosition.Model], vin[VinPosition.SerialNumber]),
                SteeringPosition = SteeringRepository.Lookup(vin[VinPosition.Transmission]),
                BodyType = BodyTypeRepository.Lookup(vin.Substring(VinPosition.BodyType, 2)),
                Seating = SeatingRepository.Lookup(vin.Substring(VinPosition.BodyType, 2)),
                Engine = EngineRepository.Lookup(vin[VinPosition.Engine]),
                SerialNumber = vin.Substring(VinPosition.SerialNumber, 5),
            };

            info.RestraintSystem = RestraintSystemRepository.Lookup(vin[VinPosition.Restraint], info.ModelYear.Text, info.Model.IsDB11Volante);
            info.Transmisson = TransmissionRepository.Lookup(vin[VinPosition.Transmission], info.Model.IsV12VantageS);

            return info;
        }
    }
}
