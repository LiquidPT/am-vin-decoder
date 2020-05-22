// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;
using AmVinDecoderLib.VinComponents.Enum;
using EnsureThat;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace AmVinDecoderLib.Repositories
{
    public class RestraintSystemRepository : BaseRepository<RestraintSystem, dynamic>
    {
        private const string Db11Volante = "Db11Volante";

        public static RestraintSystem Lookup(char vinCode, string modelYear, ModelType? model = null)
        {
            var validatedVinCode = LookupUtility.ValidateLetterVinCode(vinCode);

            if (!string.IsNullOrWhiteSpace(modelYear))
            {
                Ensure.That(modelYear, nameof(modelYear)).IsNumeric();
            }

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
            if (subdata.Count == 1)
            {
                // Only a default item. Return it.
                return subdata[Default];
            }

            // Get only the items that aren't the dafault one for examination
            var nonDefault = subdata.Where(s => s.Key != Default);

            // Sub data is for the DB 11 Volante.
            // TODO: Refactor as this is fragile
            var sample = nonDefault.First();
            if (sample.Key == Db11Volante)
            {
                if (model == ModelType.Db11Volante)
                {
                    return sample.Value;
                }

                return subdata[Default];
            }

            // Sub data is year comparison based
            // TODO: Do better validation checking here
            foreach (var yearClause in nonDefault)
            {
                if (CSharpScript.EvaluateAsync<bool>($"{modelYear}{yearClause.Key}").Result)
                {
                    return yearClause.Value;
                }
            }

            return subdata[Default];
        }
    }
}
