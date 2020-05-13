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
    public class Model
    {
        [TestMethod]
        public void Lookup_A_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('A', null);
            TestValues(result, "DB9 Coupe");
        }

        [TestMethod]
        public void Lookup_B_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('B', null);
            TestValues(result, "DB9 Volante");
        }

        [TestMethod]
        public void Lookup_C_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('C', null);
            TestValues(result, "V8/V8S Coupe");
        }

        [TestMethod]
        public void Lookup_D_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('D', null);
            TestValues(result, "V8/V8S Roadster");
        }

        [TestMethod]
        public void Lookup_E_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('E', null);
            TestValues(result, "DBS");
        }

        [TestMethod]
        public void Lookup_E0_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('E', '0');
            TestValues(result, "DBS Coupe");
        }

        [TestMethod]
        public void Lookup_E1_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('E', '1');
            TestValues(result, "DBS Volante");
        }

        [TestMethod]
        public void Lookup_F_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('F', null);
            TestValues(result, "Rapide");
        }

        [TestMethod]
        public void Lookup_G_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('G', null);
            TestValues(result, "Virage Coupe");
        }

        [TestMethod]
        public void Lookup_H_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('H', null);
            TestValues(result, "Virage Volante");
        }

        [TestMethod]
        public void Lookup_J_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('J', null);
            TestValues(result, "Vanquish Coupe");
        }

        [TestMethod]
        public void Lookup_J3_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('J', '3');
            TestValues(result, "Vanquish Zagato Coupe");
        }

        [TestMethod]
        public void Lookup_K_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('K', null);
            TestValues(result, "Vanquish Volante");
        }

        [TestMethod]
        public void Lookup_L_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('L', null);
            TestValues(result, "DB11 Coupe");
        }

        [TestMethod]
        public void Lookup_M_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('M', null);
            TestValues(result, "DB11 Volante", expectedIsDB11Volante: true);
        }

        [TestMethod]
        public void Lookup_N_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('N', null);
            TestValues(result, "New Vantage Coupe");
        }

        [TestMethod]
        public void Lookup_R_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('R', null);
            TestValues(result, "New DBS Coupe");
        }

        [TestMethod]
        public void Lookup_S_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('S', null);
            TestValues(result, "V12 Vantage Coupe");
        }

        [TestMethod]
        public void Lookup_S0_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('S', '0');
            TestValues(result, "V12 Vantage S Coupe", expectedIsV12VantageS: true);
        }

        [TestMethod]
        public void Lookup_S1_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('S', '1');
            TestValues(result, "V12 Vantage Roadster");
        }

        [TestMethod]
        public void Lookup_S2_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('S', '2');
            TestValues(result, "V12 Vantage S Roadster", expectedIsV12VantageS: true);
        }

        private void TestValues(vin.Model actual, string expectedText, bool expectedIsV12VantageS = false, bool expectedIsDB11Volante = false)
        {
            Assert.IsNotNull(actual);

            Assert.AreEqual(expectedText, actual.Text);
            Assert.AreEqual(expectedIsV12VantageS, actual.IsV12VantageS);
            Assert.AreEqual(expectedIsDB11Volante, actual.IsDB11Volante);
        }
    }
}
