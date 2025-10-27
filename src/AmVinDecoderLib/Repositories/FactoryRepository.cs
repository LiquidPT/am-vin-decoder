// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;

namespace AmVinDecoderLib.Repositories;

/// <summary>
/// Provides repository access for retrieving <see cref="Factory"/> instances by VIN code.
/// </summary>
/// <remarks>This class extends <see cref="BaseRepository{Factory}"/> to support lookup operations using a single
/// VIN code character. Use <see cref="Lookup"/> to obtain a <see cref="Factory"/> associated with a specific VIN code.
/// The repository assumes that VIN code validation is performed prior to retrieval.</remarks>
public class FactoryRepository : BaseRepository<Factory>
{
    /// <summary>
    /// Retrieves the factory associated with the specified VIN code character.
    /// </summary>
    /// <param name="vinCode">The character representing the VIN code to look up. Must be a valid VIN code letter; otherwise, an exception may
    /// be thrown.</param>
    /// <returns>The factory corresponding to the validated VIN code character.</returns>
    public Factory Lookup(char vinCode)
    {
        var validatedVinCode = LookupUtility.ValidateLetterVinCode(vinCode);
        return Repo[validatedVinCode];
    }
}
