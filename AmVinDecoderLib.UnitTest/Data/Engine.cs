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
    public class Engine
    {
        [TestMethod]
        public void Lookup_A_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('A');
            TestValues(result, "V12 AM04", 12, Induction.NormallyAspirated, 5935, 335, 6000, 570, 5000);
        }

        [TestMethod]
        public void Lookup_B_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('B');
            TestValues(result, "AM05 - 4.3", 8, Induction.NormallyAspirated, 4280, 283, 7000, 410, 5000);
        }

        [TestMethod]
        public void Lookup_C_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('C');
            TestValues(result, "AM07 - 4.7", 8, Induction.NormallyAspirated, 4735, 313, 7300, 470, 5000);
        }

        [TestMethod]
        public void Lookup_D_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('D');
            TestValues(result, "V12(DBS) AM08", 12, Induction.NormallyAspirated, 5935, 380, 6500, 570, 5750);
        }

        [TestMethod]
        public void Lookup_E_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('E');
            TestValues(result, "V12 AM09", 12, Induction.NormallyAspirated, 5935, 350, 6000, 600, 5000);
        }

        [TestMethod]
        public void Lookup_F_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('F');
            TestValues(result, "V12(Vantage) AM10", 12, Induction.NormallyAspirated, 5935, 380, 6500, 620, 5750);
        }

        [TestMethod]
        public void Lookup_G_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('G');
            TestValues(result, "GAM05 - 4.3 N400 spec", 8, Induction.NormallyAspirated, 4280, 283, 7000, 410, 5000);
        }

        [TestMethod]
        public void Lookup_J_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('J');
            TestValues(result, "V12(Rapide) AM16", 12, Induction.NormallyAspirated, 5935, 350, 6000, 600, 5000);
        }

        [TestMethod]
        public void Lookup_K_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('K');
            TestValues(result, "4.7(011MY Euro 5) AM14", 8, Induction.NormallyAspirated, 4735, 313, 7300, 470, 5000);
        }

        [TestMethod]
        public void Lookup_L_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('L');
            TestValues(result, "4.7(V8S spec) AM15", 8, Induction.NormallyAspirated, 4735, 321, 7300, 490, 5000);
        }

        [TestMethod]
        public void Lookup_M_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('M');
            TestValues(result, "V12(DB9 13MY +) AM11", 12, Induction.NormallyAspirated, 5935, 380, 6500, 620, 5500);
        }

        [TestMethod]
        public void Lookup_N_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('N');
            TestValues(result, "V12(Virage) AM25", 12, Induction.NormallyAspirated, 5935, 365, 6500, 570, 5750);
        }

        [TestMethod]
        public void Lookup_P_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('P');
            TestValues(result, "V12(Vanquish) AM11", 12, Induction.NormallyAspirated, 5935, 421, 6750, 620, 5500);
        }

        [TestMethod]
        public void Lookup_U_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('U');
            TestValues(result, "(Vanquish 15MY - AM29)", 12, Induction.NormallyAspirated, 5935, 424, 6750, 630, 5500);
        }

        [TestMethod]
        public void Lookup_R_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('R');
            TestValues(result, "V12 Vantage S AM28", 12, Induction.NormallyAspirated, 5935, 421, 6750, 620, 5750);
        }

        [TestMethod]
        public void Lookup_T_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('T');
            TestValues(result, "V12(Rapide S) AM11", 12, Induction.NormallyAspirated, 5935, 410, 6750, 620, 5500);
        }

        [TestMethod]
        public void Lookup_S_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('S');
            TestValues(result, "(RapideS 15MY - AM29)", 12, Induction.NormallyAspirated, 5935, 412, 6650, 630, 5500);
        }

        [TestMethod]
        public void Lookup_V_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('V');
            TestValues(result, "V12 Twin Turbo AE31", 12, Induction.TurboCharged, 5204, 447, 6500, 700, 1500);
        }

        [TestMethod]
        public void Lookup_VIsNgDbs_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('V', true);
            TestValues(result, "V12 Twin Turbo AE31", 12, Induction.TurboCharged, 5204, 533, 6500, 900, 1800);
        }

        [TestMethod]
        public void Lookup_W_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('W');
            TestValues(result, "V8 Twin Turbo -177590", 8, Induction.TurboCharged, 3982, 375, 6000, 685, 2000);
        }

        [TestMethod]
        public void Lookup_Z_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('Z');
            TestValues(result, "Vanquish S(Zagato) AM27", 12, Induction.NormallyAspirated, 5935, 444, 7000, 630, 5500);
        }

        private void TestValues(
            vin.Engine actual,
            string expectedText,
            int expectedCylinders,
            Induction expectedInduction,
            double expectedDisplacement,
            double? expectedPower,
            double? expectedPowerRpm,
            double? expectedTorque,
            double? expectedTorqueRpm)
        {
            Assert.IsNotNull(actual);

            Assert.AreEqual(expectedText, actual.Text);

            Assert.AreEqual(expectedCylinders, actual.Cylinders);
            Assert.AreEqual(expectedInduction, actual.Induction);
            Assert.AreEqual(expectedDisplacement, actual.DisplacementInCc);
            Assert.AreEqual(expectedPower, actual.MaxPower);
            Assert.AreEqual(PowerUnit.Kw, actual.MaxPowerUnit);
            Assert.AreEqual(expectedPowerRpm, actual.MaxPowerRpm);
            Assert.AreEqual(expectedTorque, actual.MaxTorque);
            Assert.AreEqual(TorqueUnit.Nm, actual.MaxTorqueUnit);
            Assert.AreEqual(expectedTorqueRpm, actual.MaxTorqueRpm);
        }
    }
}
