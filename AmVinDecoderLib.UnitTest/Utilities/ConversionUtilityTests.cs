// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmVinDecoderLib.UnitTest.Utilities
{
    [TestClass]
    public class ConversionUtilityTests
    {
        [TestMethod]
        public void ConvertPower_Null_ReturnsNull()
        {
            var result = ConversionUtility.ConvertPower(null, PowerUnit.Kw, PowerUnit.Bhp);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void ConvertPower_KwToHp_ReturnsCorrectValue()
        {
            var result = ConversionUtility.ConvertPower(10, PowerUnit.Kw, PowerUnit.Bhp);
            Assert.IsNotNull(result);
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void ConvertPower_HpToKw_ReturnsCorrectValue()
        {
            var result = ConversionUtility.ConvertPower(10, PowerUnit.Bhp, PowerUnit.Kw);
            Assert.IsNotNull(result);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void ConvertTorque_Null_ReturnsNull()
        {
            var result = ConversionUtility.ConvertTorque(null, TorqueUnit.Nm, TorqueUnit.LbFt);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void ConvertTorque_NmToLbFt_ReturnsCorrectValue()
        {
            var result = ConversionUtility.ConvertTorque(10, TorqueUnit.Nm, TorqueUnit.LbFt);
            Assert.IsNotNull(result);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void ConvertTorque_LbFtToNm_ReturnsCorrectValue()
        {
            var result = ConversionUtility.ConvertTorque(10, TorqueUnit.LbFt, TorqueUnit.Nm);
            Assert.IsNotNull(result);
            Assert.AreEqual(14, result);
        }
    }
}
