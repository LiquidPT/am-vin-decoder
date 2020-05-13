// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;

namespace AmVinDecoderLib.Repositories
{
    public class EngineRepository : BaseRepository<Engine>
    {
        public static Engine Lookup(char vinCode)
        {
            var validatedVinCode = LookupUtility.ValidateLetterVinCode(vinCode);
            return InitializeData()[validatedVinCode];
        }
    }
}
