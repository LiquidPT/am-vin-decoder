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
    public class EngineRepository : BaseRepository<Engine, dynamic>
    {
        private const string NgDbs = "NgDbs";

        public static Engine Lookup(char vinCode, bool isNgDbs = false)
        {
            var validatedVinCode = LookupUtility.ValidateLetterVinCode(vinCode);

            var data = InitializeData()[validatedVinCode];
            if (data.Text != null)
            {
                return data.ToObject<Engine>();
            }

            if (data[Default] != null)
            {
                var subdata = data.ToObject<Dictionary<string, Engine>>();

                if (isNgDbs)
                {
                    return subdata[NgDbs];
                }

                return subdata[Default];
            }

            throw new FormatException($"JSON node for Engine {validatedVinCode} was not in the expected format.");
        }
    }
}
