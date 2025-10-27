// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------


global using AmVinDecoderLib.VinComponents.Enums;

using AmVinDecoderLib.Repositories;
using AmVinDecoderLib.Utilities;

[assembly: CLSCompliant(false)]

namespace AmVinDecoderLib;

/// <summary>
/// Provides methods for decoding a Vehicle Identification Number (VIN) and retrieving summary information about the
/// corresponding vehicle.
/// </summary>
/// <remarks>This static class offers functionality to extract vehicle details such as factory, model year,
/// engine, transmission, and restraint system from a VIN string. All methods are static and thread-safe. The class is
/// intended for use with VINs that begin with "SCF" and are exactly 17 characters in length, corresponding to supported
/// vehicle formats.</remarks>
public static class VinDecoder
{
    /// <summary>
    /// Retrieves detailed summary information for a vehicle based on its VIN and specified unit options.
    /// </summary>
    /// <param name="vin">The 17-character vehicle identification number (VIN) used to identify the vehicle. Must not be null, empty, or
    /// shorter than 17 characters, and must start with "SCF".</param>
    /// <param name="unitOptions">The unit options specifying preferred measurement units for power and torque. Must not be null.</param>
    /// <returns>A VehicleSummary object containing information about the vehicle, including factory, model year, model, body
    /// type, serial number, engine, restraint system, and transmission details.</returns>
    public static VehicleSummary GetVehicleInfo(string? vin, UnitOptions unitOptions)
    {
        ArgumentException.ThrowIfNullOrEmpty(vin);
        ArgumentNullException.ThrowIfNull(unitOptions);
        ArgumentException.ThrowIfNotLength(vin, 17);

        var wmi = vin.Substring(VinPosition.Wmi, 3);
        ArgumentException.ThrowIfDoesNotStartWith(wmi, "SCF", StringComparison.OrdinalIgnoreCase, nameof(vin));

        var powerUnits = unitOptions.Power ?? (unitOptions.UseMetric ? PowerUnit.Kw : PowerUnit.Bhp);
        var torqueUnits = unitOptions.Torque ?? (unitOptions.UseMetric ? TorqueUnit.Nm : TorqueUnit.LbFt);

        var info = new VehicleSummary
        {
            Vin = vin,
            Factory = new FactoryRepository().Lookup(vin[VinPosition.Factory]),
            ModelYear = new ModelYearRepository().Lookup(vin[VinPosition.ModelYear]),
            Model = new ModelRepository().Lookup(vin[VinPosition.Model], vin.Substring(VinPosition.BodyType, 2), vin[VinPosition.SerialNumber]),
            BodyType = new BodyTypeRepository().Lookup(vin.Substring(VinPosition.BodyType, 2)),
            SerialNumber = vin.Substring(VinPosition.SerialNumber, 5),
        };

        info.Engine = new EngineRepository().Lookup(vin[VinPosition.Engine], powerUnits, torqueUnits, info.Model.ModelType);
        info.RestraintSystem = new RestraintSystemRepository().Lookup(vin[VinPosition.Restraint], info.ModelYear.Text, info.Model.ModelType);
        info.Transmisson = new TransmissionRepository().Lookup(vin[VinPosition.Transmission], info.Model.ModelType);

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
