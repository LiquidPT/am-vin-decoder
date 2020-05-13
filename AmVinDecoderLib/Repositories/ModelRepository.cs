using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;
using System;
using System.Collections.Generic;

namespace AmVinDecoderLib.Repositories
{
    public class ModelRepository : BaseRepository<Model, dynamic>
    {
        public static Model Lookup(char vinCode, char? serialModifer)
        {
            var validatedVinCode = LookupUtility.ValidateLetterVinCode(vinCode);

            if (serialModifer.HasValue && !char.IsDigit(serialModifer.Value))
            {
                throw new ArgumentOutOfRangeException(nameof(serialModifer), "Expecting a digit");
            }

            var data = InitializeData()[validatedVinCode];
            if (data.Text != null)
            {
                return data.ToObject<Model>();
            }

            if (data[_default] != null)
            {
                var subdata = data.ToObject<Dictionary<string, Model>>();
                Model model;
                try
                {
                    model = subdata[serialModifer.ToString()];
                }
                catch (KeyNotFoundException)
                {
                    model = subdata[_default];
                }

                return model;
            }

            throw new FormatException($"JSON node for Model {validatedVinCode} was not in the expected format.");
        }
    }
}
