// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;

namespace AmVinDecoderLib.Repositories;

/// <summary>
/// Repository for looking up Engine information based on VIN code.
/// </summary>
public class EngineRepository : BaseRepository<Engine, dynamic>
{
    /// <summary>
    /// Retrieves engine information for a specified VIN code, converting the results to the requested power and torque
    /// units. Optionally filters by model type.
    /// </summary>
    /// <param name="vinCode">A character representing a letter or digit from the VIN code to identify the engine. Must be a valid VIN
    /// character.</param>
    /// <param name="powerUnits">The unit of measurement to use for engine power in the returned result.</param>
    /// <param name="torqueUnits">The unit of measurement to use for engine torque in the returned result.</param>
    /// <param name="model">An optional model type to filter the engine lookup. If not specified, all model types are considered.</param>
    /// <returns>An Engine object containing the engine details for the specified VIN code, with power and torque values
    /// converted to the requested units. Returns null if no matching engine is found.</returns>
    public Engine Lookup(char vinCode, PowerUnit powerUnits, TorqueUnit torqueUnits, ModelType? model = null)
    {
        var validatedVinCode = LookupUtility.ValidateLetterOrDigitVinCode(vinCode);

        var result = LookupSubData(validatedVinCode, model);
        return ConvertUnits(result, powerUnits, torqueUnits);
    }

    private static Engine ConvertUnits(Engine result, PowerUnit powerUnits, TorqueUnit torqueUnits)
    {
        result.MaxPower = ConversionUtility.ConvertPower(result.MaxPower, result.MaxPowerUnit, powerUnits);
        result.MaxPowerUnit = powerUnits;
        result.MaxTorque = ConversionUtility.ConvertTorque(result.MaxTorque, result.MaxTorqueUnit, torqueUnits);
        result.MaxTorqueUnit = torqueUnits;

        return result;
    }
}
