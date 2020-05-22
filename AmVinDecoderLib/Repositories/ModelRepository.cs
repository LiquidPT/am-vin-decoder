// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;
using EnsureThat;

namespace AmVinDecoderLib.Repositories
{
    public class ModelRepository : BaseRepository<Model, dynamic>
    {
        public static Model Lookup(char vinCode, char? serialModifer)
        {
            var validatedVinCode = LookupUtility.ValidateLetterVinCode(vinCode);

            if (serialModifer.HasValue)
            {
                Ensure.That<char>(serialModifer.Value, nameof(serialModifer)).IsNumeric();
            }

            var data = InitializeData()[validatedVinCode];
            if (data.Text != null)
            {
                return data.ToObject<Model>();
            }

            if (data[Default] == null)
            {
                throw new FormatException($"JSON node for Model {validatedVinCode} was not in the expected format.");
            }

            Dictionary<string, Model> subdata = data.ToObject<Dictionary<string, Model>>();
            return LookupSubData(subdata, serialModifer.ToString());
        }
    }
}
