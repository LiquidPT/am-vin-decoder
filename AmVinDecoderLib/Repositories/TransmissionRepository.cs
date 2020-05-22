// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;
using AmVinDecoderLib.VinComponents.Enum;

namespace AmVinDecoderLib.Repositories
{
    public class TransmissionRepository : BaseRepository<Transmission, dynamic>
    {
        private const string V12VantageS = "V12VantageS";

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
                var subdata = data.ToObject<Dictionary<string, Transmission>>();

                if (model == ModelType.V12VantageSCoupe || model == ModelType.V12VantageSRoadster)
                {
                    return subdata[V12VantageS];
                }

                return subdata[Default];
            }

            throw new FormatException($"JSON node for Transmission {validatedVinCode} was not in the expected format.");
        }
    }
}
