// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;

namespace AmVinDecoderLib.Repositories;

/// <summary>
/// Provides lookup functionality for Transmission data based on a VIN code and optional model type.
/// </summary>
/// <remarks>This repository enables retrieval of Transmission objects using a single character VIN code, with
/// optional filtering by model type. If the specified model type is not found, the default Transmission is returned.
/// Throws a FormatException if the underlying data is not in the expected format.</remarks>
public class TransmissionRepository : BaseRepository<Transmission, dynamic>
{
    /// <summary>
    /// Retrieves the Transmission associated with the specified VIN code character and optional model type.
    /// </summary>
    /// <param name="vinCode"></param>
    /// <param name="model"></param>
    /// <returns>The Transmission corresponding to the validated VIN code character and specified model type. If the model type is not found,</returns>
    /// <exception cref="FormatException"></exception>
    public Transmission Lookup(char vinCode, ModelType? model = null)
    {
        var validatedVinCode = LookupUtility.ValidateLetterVinCode(vinCode);

        var data = Repo[validatedVinCode];
        if (data.Text != null)
        {
            return data.ToObject<Transmission>();
        }

        if (data[Default] != null)
        {
            Dictionary<string, Transmission> subdata = data.ToObject<Dictionary<string, Transmission>>();

            string modelText = (model == null) ? Default : model.ToString()!;

            if (subdata.TryGetValue(modelText, out var value))
            {
                return value;
            }

            return subdata[Default];
        }

        throw new FormatException($"JSON node for Transmission {validatedVinCode} was not in the expected format.");
    }
}
