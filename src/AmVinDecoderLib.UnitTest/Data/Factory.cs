// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.UnitTest.Data
{
    [TestClass]
    public class Factory
    {
        [TestMethod]
        public void Lookup_A_ReturnsExpectedValues()
        {
            var result = FactoryRepository.Lookup('A');
            TestValues(result, "Austria, Magna Steyr");
        }

        [TestMethod]
        public void Lookup_G_ReturnsExpectedValues()
        {
            var result = FactoryRepository.Lookup('G');
            TestValues(result, "England, Gaydon");
        }

        [TestMethod]
        public void Lookup_J_ReturnsExpectedValues()
        {
            var result = FactoryRepository.Lookup('J');
            TestValues(result, "Japan, Toyota, Aichi");
        }

        [TestMethod]
        public void Lookup_T_ReturnsExpectedValues()
        {
            var result = FactoryRepository.Lookup('T');
            TestValues(result, "Wales, Saint Athan");
        }

        private void TestValues(vin.Factory actual, string expectedText)
        {
            Assert.IsNotNull(actual);

            Assert.AreEqual(expectedText, actual.Text);
        }
    }
}
