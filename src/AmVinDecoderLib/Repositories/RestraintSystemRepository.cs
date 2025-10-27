// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace AmVinDecoderLib.Repositories;

/// <summary>
/// Provides data access and lookup functionality for restraint system information based on VIN code, model year, and
/// model type.
/// </summary>
/// <remarks>This repository enables retrieval of restraint system details for vehicles by leveraging validated
/// VIN codes and model year information. It extends the generic BaseRepository to support domain-specific queries
/// related to restraint systems. Thread safety and caching behavior depend on the underlying BaseRepository
/// implementation.</remarks>
public class RestraintSystemRepository : BaseRepository<RestraintSystem, dynamic>
{
    /// <summary>
    /// Retrieves the restraint system information for a vehicle based on the specified VIN code letter, model year, and
    /// optional model type.
    /// </summary>
    /// <param name="vinCode">The character representing the VIN code letter to look up. Must be a valid VIN code letter.</param>
    /// <param name="modelYear">The model year of the vehicle to look up. Must be a numeric value.</param>
    /// <param name="model">An optional value specifying the model type of the vehicle. If null, the lookup is performed without filtering
    /// by model type.</param>
    /// <returns>A RestraintSystem object containing the restraint system details for the specified vehicle. Returns null if no
    /// matching restraint system is found.</returns>
    public RestraintSystem Lookup(char vinCode, string modelYear, ModelType? model = null)
    {
        var validatedVinCode = LookupUtility.ValidateLetterVinCode(vinCode);
        ArgumentOutOfRangeException.ThrowIfNotNumericOrNull(modelYear);

        return LookupSubData(validatedVinCode, model, (key) => key.Contains("{modelYear}", StringComparison.InvariantCultureIgnoreCase) && CSharpScript.EvaluateAsync<bool>(key.Replace("{modelYear}", modelYear, StringComparison.InvariantCultureIgnoreCase)).Result);
    }
}
