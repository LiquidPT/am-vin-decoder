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
                var model = data.ToObject<Model>();
                return PopulateBooleanFields(model, validatedVinCode, serialModifer);
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

                return PopulateBooleanFields(model, validatedVinCode, serialModifer);
            }

            throw new FormatException($"JSON node for Model {validatedVinCode} was not in the expected format.");
        }

        private static Model PopulateBooleanFields(Model model, string validatedVinCode, char? serialModifer)
        {
            model.IsV12VantageS = IsV12VantageS(validatedVinCode, serialModifer.GetValueOrDefault());
            model.IsDB11Volante = IsDB11Volante(validatedVinCode);

            return model;
        }

        private static bool IsV12VantageS(string validatedVinCode, char serialmodifier)
        {
            if (!validatedVinCode.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            var sMod = serialmodifier;
            if (sMod == '0' || sMod == '2')
            {
                return true;
            }

            return false;
        }

        private static bool IsDB11Volante(string validatedVinCode)
        {
            if (validatedVinCode.Equals("M", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            return false;
        }
    }
}
