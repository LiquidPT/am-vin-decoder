using AmVinDecoderLib.VinComponents;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace AmVinDecoderLib.Repositories
{
    public class BaseRepository<TFile, TDictionary> where TFile : BaseVinComponent
    {
        private static Dictionary<string, TDictionary> _repo;
        private const string DataPath = @".\Data\";

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
