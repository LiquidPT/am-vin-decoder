// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.VinComponents;
using AmVinDecoderLib.VinComponents.Enums;
using EnsureThat;
using Newtonsoft.Json;

namespace AmVinDecoderLib.Repositories
{
    public class BaseRepository<TFile> : BaseRepository<TFile, TFile>
    where TFile : BaseVinComponent
    {
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:File may only contain a single type", Justification = "Type only differs by number of generic parameters")]
    public class BaseRepository<TFile, TDictionary>
        where TFile : BaseVinComponent
    {
        private static Dictionary<string, TDictionary> _repo;
        private const string DataPath = @"./Data/";

        protected const string Default = "default";

        protected static Dictionary<string, TDictionary> InitializeData()
        {
            if (_repo == null)
            {
                var json = File.ReadAllText($"{DataPath}{typeof(TFile).Name}.json");
                var repo = JsonConvert.DeserializeObject<Dictionary<string, TDictionary>>(json);
                _repo = repo;
            }

            return _repo;
        }

        protected static TFile LookupSubData(string validatedVinCode, ModelType? model, Func<string, bool> subselectionClause = null)
        {
            return LookupSubData(validatedVinCode, model.ToString(), subselectionClause);
        }

        protected static TFile LookupSubData(string validatedVinCode, string secondaryLookupKey, Func<string, bool> subselectionClause = null)
        {
            string[] secondaryLookupKeys = { secondaryLookupKey };
            return LookupSubData(validatedVinCode, secondaryLookupKeys, subselectionClause);
        }

        protected static TFile LookupSubData(string validatedVinCode, string[] secondaryLookupKeys, Func<string, bool> subselectionClause = null)
        {
            Ensure.That(validatedVinCode, nameof(validatedVinCode)).IsNotNullOrWhiteSpace();

            var data = (dynamic)InitializeData()[validatedVinCode];
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
}
