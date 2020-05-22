// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;
using AmVinDecoderLib.VinComponents.Enum;
using EnsureThat;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace AmVinDecoderLib.Repositories
{
    public class RestraintSystemRepository : BaseRepository<RestraintSystem, dynamic>
    {
        public static RestraintSystem Lookup(char vinCode, string modelYear, ModelType? model = null)
        {
            var validatedVinCode = LookupUtility.ValidateLetterVinCode(vinCode);
            Ensure.That(modelYear, nameof(modelYear)).IsNullOrNumeric();

            var data = InitializeData()[validatedVinCode];
            if (data.Text != null)
            {
                return data.ToObject<RestraintSystem>();
            }

            if (data[Default] == null)
            {
                throw new FormatException($"JSON node for RestraintSystem {validatedVinCode} was not in the expected format.");
            }

            Dictionary<string, RestraintSystem> subdata = data.ToObject<Dictionary<string, RestraintSystem>>();
            return LookupSubData(subdata, model, (key) => key.Contains("{modelYear}") && CSharpScript.EvaluateAsync<bool>(key.Replace("{modelYear}", modelYear)).Result);
        }
    }
}
