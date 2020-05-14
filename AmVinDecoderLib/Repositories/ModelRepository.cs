// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;

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

            if (data[Default] != null)
            {
                var subdata = data.ToObject<Dictionary<string, Model>>();
                Model model;
                try
                {
                    model = subdata[serialModifer.ToString()];
                }
                catch (KeyNotFoundException)
                {
                    model = subdata[Default];
                }

                return model;
            }

            throw new FormatException($"JSON node for Model {validatedVinCode} was not in the expected format.");
        }
    }
}
