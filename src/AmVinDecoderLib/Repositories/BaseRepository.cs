// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.VinComponents;
using Newtonsoft.Json;

namespace AmVinDecoderLib.Repositories;

/// <summary>
/// Provides a base implementation of a repository for managing entities of type <typeparamref name="TFile"/>.
/// </summary>
/// <typeparam name="TFile">The type of entity managed by the repository. Must inherit from <see cref="BaseVinComponent"/>.</typeparam>
public class BaseRepository<TFile> : BaseRepository<TFile, TFile>
where TFile : BaseVinComponent
{
}

/// <summary>
/// Provides a base repository for loading and accessing VIN component data from JSON files, supporting flexible lookup
/// operations using string keys and optional selection criteria.
/// </summary>
/// <remarks>This class is intended to be used as a base for repositories that manage VIN component data. Data is
/// loaded from a JSON file named after the type parameter TFile and cached for subsequent access. Lookup methods
/// support searching by VIN code and optional secondary keys or selection clauses, returning the most relevant
/// component or a default if no match is found. Thread safety is not guaranteed; concurrent access may require
/// additional synchronization.</remarks>
/// <typeparam name="TFile">The type of VIN component to be returned by lookup operations. Must inherit from BaseVinComponent.</typeparam>
/// <typeparam name="TDictionary">The type of objects stored in the internal dictionary and loaded from the data source.</typeparam>
[System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:File may only contain a single type", Justification = "Type only differs by number of generic parameters")]
public class BaseRepository<TFile, TDictionary>
    where TFile : BaseVinComponent
{
    private static Dictionary<string, TDictionary> _repo;
    private const string DataPath = @"./Data/";

    /// <summary>
    /// Represents the default value used for configuration or initialization within the containing type.
    /// </summary>
    protected const string Default = "default";

    /// <summary>
    /// Gets the internal dictionary that maps string keys to values of type <typeparamref name="TDictionary"/>.
    /// </summary>
    protected Dictionary<string, TDictionary> Repo => _repo;

    /// <summary>
    /// Initializes a new instance of the BaseRepository class and loads repository data from a JSON file.
    /// </summary>
    /// <remarks>The constructor reads a JSON file named after the type parameter and deserializes its
    /// contents into the repository. If the file does not match the expected format, a FormatException is thrown. This
    /// ensures that the repository is populated with valid data upon initialization.</remarks>
    /// <exception cref="FormatException">Thrown if the data file for the specified type is not in the expected format.</exception>
    public BaseRepository()
    {
        if (_repo == null)
        {
            var json = File.ReadAllText($"{DataPath}{typeof(TFile).Name}.json");
            var repo = JsonConvert.DeserializeObject<Dictionary<string, TDictionary>>(json) ?? throw new FormatException($"Data file for {typeof(TFile).Name} was not in the expected format.");
            _repo = repo;
        }
    }

    /// <summary>
    /// Looks up sub-data for a given validated VIN code and optional model type, applying an optional subselection clause.
    /// </summary>
    /// <param name="validatedVinCode"></param>
    /// <param name="model"></param>
    /// <param name="subselectionClause"></param>
    /// <returns></returns>
    protected TFile LookupSubData(string validatedVinCode, ModelType? model, Func<string, bool>? subselectionClause = null)
    {
        return LookupSubData(validatedVinCode, model?.ToString(), subselectionClause);
    }

    /// <summary>
    /// Retrieves sub-data associated with the specified VIN code and an optional secondary lookup key, applying an
    /// optional subselection clause.
    /// </summary>
    /// <param name="validatedVinCode">The validated vehicle identification number (VIN) code used as the primary key for the lookup. Cannot be null.</param>
    /// <param name="secondaryLookupKey">An optional secondary key used to further refine the lookup. If null, only the VIN code is used.</param>
    /// <param name="subselectionClause">An optional predicate function that determines whether a sub-data item should be included in the result. If
    /// null, all items are included.</param>
    /// <returns>The sub-data of type TFile that matches the specified VIN code, secondary lookup key, and subselection clause.</returns>
    protected TFile LookupSubData(string validatedVinCode, string? secondaryLookupKey, Func<string, bool>? subselectionClause = null)
    {
        List<string>? secondaryLookupKeys = (secondaryLookupKey == null) ? null : [secondaryLookupKey];
        return LookupSubData(validatedVinCode, secondaryLookupKeys, subselectionClause);
    }

    /// <summary>
    /// Looks up sub-data for a given validated VIN code and optional secondary lookup keys, applying an optional subselection clause.
    /// </summary>
    /// <param name="validatedVinCode"></param>
    /// <param name="secondaryLookupKeys"></param>
    /// <param name="subselectionClause"></param>
    /// <returns>The sub-data of type <typeparamref name="TFile"/> that matches the specified VIN code, secondary lookup keys,</returns>
    /// <exception cref="FormatException"></exception>
    protected TFile LookupSubData(string validatedVinCode, IEnumerable<string>? secondaryLookupKeys, Func<string, bool>? subselectionClause = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(validatedVinCode);

        var data = Repo[validatedVinCode] as dynamic ?? throw new InvalidDataException($"No data found for {validatedVinCode}");

        if (data.Text != null)
        {
            return data.ToObject<TFile>();
        }

        if (data[Default] == null)
        {
            throw new FormatException($"JSON node for {typeof(TFile).Name} {validatedVinCode} was not in the expected format.");
        }

        Dictionary<string, TFile> subdata = data.ToObject<Dictionary<string, TFile>>();
        if (subdata.Count == 1)
        {
            // Only a default item. Return it.
            return subdata[Default];
        }

        // Get only the items that aren't the default one for examination
        var nonDefault = subdata.Where(s => s.Key != Default);
        foreach (var item in nonDefault)
        {
            if (secondaryLookupKeys != null && secondaryLookupKeys.Contains(item.Key))
            {
                // Key is for this model
                return item.Value;
            }

            if (subselectionClause != null && subselectionClause(item.Key))
            {
                // Key is an expression of the model year
                return item.Value;
            }
        }

        return subdata[Default];
    }
}
