// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmVinDecoderLib.UnitTest.Utilities
{
    [TestClass]
    public class ConversionUtilityTests
    {
        [TestMethod]
        public void PowerInKwToHp_Null_ReturnsNull()
        {
            var result = ConversionUtility.PowerInKwToHp(null);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void PowerInKwToHp_Value_ReturnsCorrectValue()
        {
            var result = ConversionUtility.PowerInKwToHp(10);
            Assert.IsNotNull(result);
            Assert.AreEqual(13.41, result);
        }

        [TestMethod]
        public void TorqueInNmToLbFt_Null_ReturnsNull()
        {
            var result = ConversionUtility.TorqueInNmToLbFt(null);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TorqueInNmToLbFt_Value_ReturnsCorrectValue()
        {
            var result = ConversionUtility.TorqueInNmToLbFt(10);
            Assert.IsNotNull(result);
            Assert.AreEqual(7.38, result);
        }
    }
}
