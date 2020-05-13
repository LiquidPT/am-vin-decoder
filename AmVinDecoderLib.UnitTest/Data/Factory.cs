// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using vin = AmVinDecoderLib.VinComponents;

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
            TestValues(result, "Gaydon");
        }

        private void TestValues(vin.Factory actual, string expectedText)
        {
            Assert.IsNotNull(actual);

            Assert.AreEqual(expectedText, actual.Text);
        }
    }
}
