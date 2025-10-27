// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;

namespace AmVinDecoderLib.Repositories;

/// <summary>
/// Provides repository operations for retrieving and managing Model entities.
/// </summary>
/// <remarks>This class extends BaseRepository to support lookup and data access for Model objects using VIN
/// codes, body codes, and optional serial modifiers. It is intended for scenarios where models are identified by a
/// combination of these codes. Thread safety and usage patterns are inherited from BaseRepository.</remarks>
public class ModelRepository : BaseRepository<Model, dynamic>
{
    /// <summary>
    /// Retrieves a model based on the specified VIN code, body code, and optional serial modifier.
    /// </summary>
    /// <param name="vinCode">A character representing the VIN code. Must be a letter or digit.</param>
    /// <param name="bodyCode">A string representing the body code. Must be a letter or digit and may be null.</param>
    /// <param name="serialModifer">An optional character representing the serial modifier. Must be numeric or null.</param>
    /// <returns>A Model instance that matches the provided VIN code, body code, and serial modifier. Returns null if no matching
    /// model is found.</returns>
    public Model Lookup(char vinCode, string bodyCode, char? serialModifer)
    {
        var validatedVinCode = LookupUtility.ValidateLetterOrDigitVinCode(vinCode);
        var validatedBodyCode = LookupUtility.ValidateLetterOrDigitVinCode(bodyCode, 2, allowNull: true);

        ArgumentOutOfRangeException.ThrowIfNotNumericOrNull(serialModifer);



        List<string> keys = new List<string>();
        if (validatedBodyCode != null)
        {
            keys.Add(validatedBodyCode);
        }

        if (serialModifer.HasValue)
        {
            keys.Add(serialModifer.Value.ToString());
        }
        return LookupSubData(validatedVinCode, keys);
    }
}
