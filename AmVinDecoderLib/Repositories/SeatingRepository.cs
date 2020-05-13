// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;

namespace AmVinDecoderLib.Repositories
{
    public class SeatingRepository : BaseRepository<Seating>
    {
        public static Seating Lookup(string vinCode)
        {
            var validatedVinCode = LookupUtility.ValidateLetterOrDigitVinCode(vinCode, 2);
            return InitializeData()[validatedVinCode];
        }
    }
}
