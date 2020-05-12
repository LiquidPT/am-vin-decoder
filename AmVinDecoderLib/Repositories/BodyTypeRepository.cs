using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace AmVinDecoderLib.Repositories
{
    public class BodyTypeRepository
    {
        private static Dictionary<string, BodyType> _repo;
        private const string DataPath = @".\Data\";

        public static BodyType Lookup(string vinCode)
        {
            var validatedVinCode = LookupUtility.ValidateLetterOrDigitVinCode(vinCode, 2);

            InitializeData();

            return _repo[validatedVinCode];
        }

        private static void InitializeData()
        {
            if (_repo == null)
            {
                var json = File.ReadAllText($"{DataPath}BodyType.json");
                Dictionary<string, BodyType> repo = JsonConvert.DeserializeObject<Dictionary<string, BodyType>>(json);
                _repo = repo;
            }
        }
    }
}
