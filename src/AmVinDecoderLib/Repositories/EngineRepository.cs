// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;
using AmVinDecoderLib.VinComponents.Enums;

namespace AmVinDecoderLib.Repositories
{
    public class EngineRepository : BaseRepository<Engine, dynamic>
    {
        public static Engine Lookup(char vinCode, PowerUnit powerUnits, TorqueUnit torqueUnits, ModelType? model = null)
        {
            var validatedVinCode = LookupUtility.ValidateLetterOrDigitVinCode(vinCode);

            var result = LookupSubData(validatedVinCode, model);
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
