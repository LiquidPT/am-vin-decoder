// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Repositories;
using AmVinDecoderLib.VinComponents.Enum;
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
            var result = ModelRepository.Lookup('A', null, null);
            TestValues(result, "DB9 Coupe", ModelType.Db9Coupe);
        }

        [TestMethod]
        public void Lookup_B_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('B', null, null);
            TestValues(result, "DB9 Volante", ModelType.Db9Volante);
        }

        [TestMethod]
        public void Lookup_C_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('C', null, null);
            TestValues(result, "V8/V8S Coupe", ModelType.V8VantageCoupe);
        }

        [TestMethod]
        public void Lookup_D_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('D', null, null);
            TestValues(result, "V8/V8S Roadster", ModelType.V8VantageRoadster);
        }

        [TestMethod]
        public void Lookup_E_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('E', null, null);
            TestValues(result, "DBS", ModelType.Dbs);
        }

        [TestMethod]
        public void Lookup_E0_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('E', null, '0');
            TestValues(result, "DBS Coupe", ModelType.DbsCoupe);
        }

        [TestMethod]
        public void Lookup_E1_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('E', null, '1');
            TestValues(result, "DBS Volante", ModelType.DbsVolante);
        }

        [TestMethod]
        public void Lookup_F_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('F', null, null);
            TestValues(result, "Rapide", ModelType.Rapide);
        }

        [TestMethod]
        public void Lookup_G_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('G', null, null);
            TestValues(result, "Virage Coupe", ModelType.VirageCoupe);
        }

        [TestMethod]
        public void Lookup_H_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('H', null, null);
            TestValues(result, "Virage Volante", ModelType.VirageVolante);
        }

        [TestMethod]
        public void Lookup_J_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('J', null, null);
            TestValues(result, "Vanquish Coupe", ModelType.VanquishCoupe);
        }

        [TestMethod]
        public void Lookup_J3_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('J', null, '3');
            TestValues(result, "Vanquish Zagato Coupe", ModelType.VanquishZagatoCoupe);
        }

        [TestMethod]
        public void Lookup_K_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('K', null, null);
            TestValues(result, "Vanquish Volante", ModelType.VanquishVolante);
        }

        [TestMethod]
        public void Lookup_L_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('L', null, null);
            TestValues(result, "DB11 Coupe", ModelType.Db11Coupe);
        }

        [TestMethod]
        public void Lookup_LFE_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('L', "FE", null);
            TestValues(result, "DB11 AMR", ModelType.Db11Amr);
        }

        [TestMethod]
        public void Lookup_M_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('M', null, null);
            TestValues(result, "DB11 Volante", ModelType.Db11Volante);
        }

        [TestMethod]
        public void Lookup_N_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('N', null, null);
            TestValues(result, "New Vantage Coupe", ModelType.NewVantageCoupe);
        }

        [TestMethod]
        public void Lookup_R_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('R', null, null);
            TestValues(result, "New DBS Coupe", ModelType.NewDbsCoupe);
        }

        [TestMethod]
        public void Lookup_S_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('S', null, null);
            TestValues(result, "V12 Vantage Coupe", ModelType.V12VantageCoupe);
        }

        [TestMethod]
        public void Lookup_S0_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('S', null, '0');
            TestValues(result, "V12 Vantage S Coupe", ModelType.V12VantageSCoupe);
        }

        [TestMethod]
        public void Lookup_S1_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('S', null, '1');
            TestValues(result, "V12 Vantage Roadster", ModelType.V12VantageRoadster);
        }

        [TestMethod]
        public void Lookup_S2_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('S', null, '2');
            TestValues(result, "V12 Vantage S Roadster", ModelType.V12VantageSRoadster);
        }

        [TestMethod]
        public void Lookup_T_ReturnsExpectedValues()
        {
            var result = ModelRepository.Lookup('T', null, null);
            TestValues(result, "New DBS Volante", ModelType.NewDbsVolante);
        }

        private void TestValues(vin.Model actual, string expectedText, ModelType expectedModelType)
        {
            Assert.IsNotNull(actual);

            Assert.AreEqual(expectedText, actual.Text);
            Assert.AreEqual(expectedModelType, actual.ModelType);
        }
    }
}
