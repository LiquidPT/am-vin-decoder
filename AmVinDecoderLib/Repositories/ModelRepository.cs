// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;
using EnsureThat;

namespace AmVinDecoderLib.Repositories
{
    public class ModelRepository : BaseRepository<Model, dynamic>
    {
        public static Model Lookup(char vinCode, string bodyCode, char? serialModifer)
        {
            var validatedVinCode = LookupUtility.ValidateLetterVinCode(vinCode);
            var validatedBodyCode = LookupUtility.ValidateLetterOrDigitVinCode(bodyCode, 2, allowNull: true);

            Ensure.That(serialModifer, nameof(serialModifer)).IsNullOrNumeric();

            string[] keys = { validatedBodyCode, serialModifer.ToString() };
            return LookupSubData(validatedVinCode, keys);
        }
    }
}
