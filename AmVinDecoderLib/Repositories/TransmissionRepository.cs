using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;
using System;
using System.Collections.Generic;

namespace AmVinDecoderLib.Repositories
{
    public class TransmissionRepository : BaseRepository<Transmission, dynamic>
    {
        protected const string _V12VantageS = "V12VantageS";

        public static Transmission Lookup(char vinCode, bool isV12VantageS = false)
        {
            var validatedVinCode = LookupUtility.ValidateLetterVinCode(vinCode);

            var data = InitializeData()[validatedVinCode];
            if (data.Text != null)
            {
                return data.ToObject<Transmission>();
            }

            if (data[_default] != null)
            {
                var subdata = data.ToObject<Dictionary<string, Transmission>>();

                if (isV12VantageS)
                {
                    return subdata[_V12VantageS];
                }

                return subdata[_default];
            }

            throw new FormatException($"JSON node for Model {validatedVinCode} was not in the expected format.");
        }
    }
}
