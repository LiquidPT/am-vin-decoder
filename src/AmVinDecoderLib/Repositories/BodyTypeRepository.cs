// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;

namespace AmVinDecoderLib.Repositories;

/// <summary>
/// Repository for looking up BodyType information based on VIN code.
/// </summary>
public class BodyTypeRepository : BaseRepository<BodyType>
{
    /// <summary>
    /// Retrieves the body type associated with the specified VIN code.
    /// </summary>
    /// <param name="vinCode">The VIN code to look up. Must consist of letters or digits and be at least two characters long.</param>
    /// <returns>The body type corresponding to the validated VIN code.</returns>
    public BodyType Lookup(string vinCode)
    {
        var validatedVinCode = LookupUtility.ValidateLetterOrDigitVinCode(vinCode, 2);
        return Repo[validatedVinCode];
    }
}
