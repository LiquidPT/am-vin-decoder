// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.IO;
using AmVinDecoderLib.VinComponents;
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
    }
}
