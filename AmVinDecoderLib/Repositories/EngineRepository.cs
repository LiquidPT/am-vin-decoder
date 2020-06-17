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
    public class EngineRepository : BaseRepository<Engine, dynamic>
    {
        private const string NgDbs = "NgDbs";

        public static Engine Lookup(char vinCode, PowerUnit powerUnits, TorqueUnit torqueUnits, bool isNgDbs = false)
        {
            var validatedVinCode = LookupUtility.ValidateLetterOrDigitVinCode(vinCode);
            Engine result = null;

            var data = InitializeData()[validatedVinCode];
            if (data.Text != null)
            {
                result = data.ToObject<Engine>();
            }
            else if (data[Default] != null)
            {
                var subdata = data.ToObject<Dictionary<string, Engine>>();

                if (isNgDbs)
                {
                    result = subdata[NgDbs];
                }
                else
                {
                    result = subdata[Default];
                }
            }

            if (result == null)
            {
                throw new FormatException($"JSON node for Engine {validatedVinCode} was not in the expected format.");
            }

            return ConvertUnits(result, powerUnits, torqueUnits);
        }

        private static Engine ConvertUnits(Engine result, PowerUnit powerUnits, TorqueUnit torqueUnits)
        {
            result.MaxPower = ConversionUtility.ConvertPower(result.MaxPower, result.MaxPowerUnit, powerUnits);
            result.MaxPowerUnit = powerUnits;
            result.MaxTorque = ConversionUtility.ConvertTorque(result.MaxTorque, result.MaxTorqueUnit, torqueUnits);
            result.MaxTorqueUnit = torqueUnits;

            return result;
        }
    }
}
