// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;
using AmVinDecoderLib.VinComponents.Enums;
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

            return LookupSubData(validatedVinCode, model, (key) => key.Contains("{modelYear}", StringComparison.InvariantCultureIgnoreCase) && CSharpScript.EvaluateAsync<bool>(key.Replace("{modelYear}", modelYear, StringComparison.InvariantCultureIgnoreCase)).Result);
        }
    }
}
