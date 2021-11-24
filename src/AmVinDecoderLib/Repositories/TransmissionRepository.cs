// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;
using AmVinDecoderLib.VinComponents.Enums;

namespace AmVinDecoderLib.Repositories
{
    public class TransmissionRepository : BaseRepository<Transmission, dynamic>
    {
        public static Transmission Lookup(char vinCode, ModelType? model = null)
        {
            var validatedVinCode = LookupUtility.ValidateLetterVinCode(vinCode);

            var data = InitializeData()[validatedVinCode];
            if (data.Text != null)
            {
                return data.ToObject<Transmission>();
            }

            if (data[Default] != null)
            {
                Dictionary<string, Transmission> subdata = data.ToObject<Dictionary<string, Transmission>>();

                if (subdata.ContainsKey(model.ToString()))
                {
                    return subdata[model.ToString()];
                }

                return subdata[Default];
            }

            throw new FormatException($"JSON node for Transmission {validatedVinCode} was not in the expected format.");
        }
    }
}
