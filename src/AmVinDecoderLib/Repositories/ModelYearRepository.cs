// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Globalization;
using AmVinDecoderLib.Properties;
using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;

namespace AmVinDecoderLib.Repositories;

/// <summary>
/// Provides functionality to retrieve model year information based on a VIN code character.
/// </summary>
/// <remarks>This repository translates a single alphanumeric VIN code character into its corresponding model year
/// representation. It is intended for use in scenarios where decoding vehicle identification numbers is required. The
/// class is designed for consistency in usage and may be extended to support additional VIN decoding
/// features.</remarks>
public class ModelYearRepository
{
    /// <summary>
    /// Retrieves the model year information corresponding to the specified VIN code character.
    /// </summary>
    /// <remarks>Throws an exception if the provided VIN code character is not alphanumeric. The returned
    /// ModelYear object contains the textual representation of the model year as determined by the VIN code.</remarks>
    /// <param name="vinCode">The VIN code character to look up. Must be an alphanumeric character representing a model year code.</param>
    /// <returns>A ModelYear instance containing the model year information for the specified VIN code character.</returns>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "For consistency")]
    public ModelYear Lookup(char vinCode)
    {
        ArgumentOutOfRangeException.ThrowIfNotAlphaNumeric(vinCode);

        return new ModelYear
        {
            Text = GetText(vinCode),
        };
    }

    private static string GetText(char vinCode)
    {
        var digit = (int)char.GetNumericValue(vinCode);
        if (digit > -1)
        {
            return (2000 + digit).ToString(CultureInfo.InvariantCulture);
        }

        if (char.IsLetter(vinCode))
        {
            var index = char.ToUpper(vinCode, CultureInfo.InvariantCulture) - 65;
            if (index >= 9)
            {
                // The letter "I" was skipped
                index -= 1;
            }

            return (index + 2010).ToString(CultureInfo.InvariantCulture);
        }

        throw new ArgumentException(Resources.Error_BadModelYear);
    }
}
