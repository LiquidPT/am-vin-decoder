// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.UnitTest.Data
{
    [TestClass]
    public class Engine
    {
        private readonly PowerUnit powerUnit = PowerUnit.Kw;
        private readonly TorqueUnit torqueUnit = TorqueUnit.Nm;

        [TestMethod]
        public void Lookup_A_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('A', powerUnit, torqueUnit);
            TestValues(result, "V12 AM04", "AM04", 12, Induction.NormallyAspirated, 5935, 336, 6000, 569, 5000);
        }

        [TestMethod]
        public void Lookup_B_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('B', powerUnit, torqueUnit);
            TestValues(result, "AM05 - 4.3", "AM05", 8, Induction.NormallyAspirated, 4280, 283, 7000, 409, 5000);
        }

        [TestMethod]
        public void Lookup_C_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('C', powerUnit, torqueUnit);
            TestValues(result, "AM07 - 4.7", "AM07", 8, Induction.NormallyAspirated, 4735, 313, 7300, 469, 5000);
        }

        [TestMethod]
        public void Lookup_D_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('D', powerUnit, torqueUnit);
            TestValues(result, "V12(DBS) AM08", "AM08", 12, Induction.NormallyAspirated, 5935, 380, 6500, 569, 5750);
        }

        [TestMethod]
        public void Lookup_E_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('E', powerUnit, torqueUnit);
            TestValues(result, "V12 AM09", "AM09", 12, Induction.NormallyAspirated, 5935, 350, 6000, 601, 5000);
        }

        [TestMethod]
        public void Lookup_F_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('F', powerUnit, torqueUnit);
            TestValues(result, "V12(Vantage) AM10", "AM10", 12, Induction.NormallyAspirated, 5935, 380, 6500, 569, 5750);
        }

        [TestMethod]
        public void Lookup_G_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('G', powerUnit, torqueUnit);
            TestValues(result, "GAM05 - 4.3 N400 spec", "GAM05", 8, Induction.NormallyAspirated, 4280, 298, 7000, 419, 5000);
        }

        [TestMethod]
        public void Lookup_J_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('J', powerUnit, torqueUnit);
            TestValues(result, "V12(Rapide) AM16", "AM16", 12, Induction.NormallyAspirated, 5935, 350, 6000, 601, 5000);
        }

        [TestMethod]
        public void Lookup_K_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('K', powerUnit, torqueUnit);
            TestValues(result, "4.7(011MY Euro 5) AM14", "AM14", 8, Induction.NormallyAspirated, 4735, 313, 7300, 469, 5000);
        }

        [TestMethod]
        public void Lookup_L_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('L', powerUnit, torqueUnit);
            TestValues(result, "4.7(V8S spec) AM15", "AM15", 8, Induction.NormallyAspirated, 4735, 321, 7300, 489, 5000);
        }

        [TestMethod]
        public void Lookup_M_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('M', powerUnit, torqueUnit);
            TestValues(result, "V12(DB9 13MY +) AM11", "AM11", 12, Induction.NormallyAspirated, 5935, 380, 6500, 620, 5500);
        }

        [TestMethod]
        public void Lookup_N_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('N', powerUnit, torqueUnit);
            TestValues(result, "V12(Virage) AM25", "AM25", 12, Induction.NormallyAspirated, 5935, 365, 6500, 569, 5750);
        }

        [TestMethod]
        public void Lookup_P_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('P', powerUnit, torqueUnit);
            TestValues(result, "V12(Vanquish) AM11", "AM11", 12, Induction.NormallyAspirated, 5935, 421, 6750, 620, 5500);
        }

        [TestMethod]
        public void Lookup_U_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('U', powerUnit, torqueUnit);
            TestValues(result, "(Vanquish 15MY - AM29)", "AM29", 12, Induction.NormallyAspirated, 5935, 424, 6750, 630, 5500);
        }

        [TestMethod]
        public void Lookup_R_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('R', powerUnit, torqueUnit);
            TestValues(result, "V12 Vantage S AM28", "AM28", 12, Induction.NormallyAspirated, 5935, 421, 6750, 620, 5750);
        }

        [TestMethod]
        public void Lookup_T_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('T', powerUnit, torqueUnit);
            TestValues(result, "V12(Rapide S) AM11", "AM11", 12, Induction.NormallyAspirated, 5935, 410, 6750, 620, 5500);
        }

        [TestMethod]
        public void Lookup_S_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('S', powerUnit, torqueUnit);
            TestValues(result, "(RapideS 15MY - AM29)", "AM29", 12, Induction.NormallyAspirated, 5935, 412, 6650, 630, 5500);
        }

        [TestMethod]
        public void Lookup_V_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('V', powerUnit, torqueUnit);
            TestValues(result, "V12 Twin Turbo AE31", "AE31", 12, Induction.TurboCharged, 5204, 447, 6500, 700, 1500);
        }

        [TestMethod]
        public void Lookup_VIsNewDbsCoupe_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('V', powerUnit, torqueUnit, ModelType.NewDbsCoupe);
            TestValues(result, "V12 Twin Turbo AE31", "AE31", 12, Induction.TurboCharged, 5204, 533, 6500, 899, 1800);
        }

        [TestMethod]
        public void Lookup_VIsDb11Amr_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('V', PowerUnit.Bhp, TorqueUnit.LbFt, ModelType.Db11Amr);
            TestValues(result, "V12 Twin Turbo AE31", "AE31", 12, Induction.TurboCharged, 5204, 630, 6500, 516, 1500, PowerUnit.Bhp, TorqueUnit.LbFt);
        }

        [TestMethod]
        public void Lookup_W_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('W', powerUnit, torqueUnit);
            TestValues(result, "V8 Twin Turbo -177590", "M177", 8, Induction.TurboCharged, 3982, 375, 6000, 685, 2000);
        }

        [TestMethod]
        public void Lookup_WIsDb11Coupe_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('W', PowerUnit.Bhp, TorqueUnit.LbFt, ModelType.Db11Coupe);
            TestValues(result, "V8 Twin Turbo -177590", "M177", 8, Induction.TurboCharged, 3982, 503, 6000, 513, 2000, PowerUnit.Bhp, TorqueUnit.LbFt);
        }

        [TestMethod]
        public void Lookup_WIsDb11Volante_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('W', PowerUnit.Bhp, TorqueUnit.LbFt, ModelType.Db11Volante);
            TestValues(result, "V8 Twin Turbo -177590", "M177", 8, Induction.TurboCharged, 3982, 503, 6000, 513, 2000, PowerUnit.Bhp, TorqueUnit.LbFt);
        }

        [TestMethod]
        public void Lookup_WIsDbx_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('W', PowerUnit.Bhp, TorqueUnit.LbFt, ModelType.Dbx);
            TestValues(result, "V8 Twin Turbo -177590", "M177", 8, Induction.TurboCharged, 3982, 542, 6500, 516, 2200, PowerUnit.Bhp, TorqueUnit.LbFt);
        }

        [TestMethod]
        public void Lookup_Z_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('Z', powerUnit, torqueUnit);
            TestValues(result, "Vanquish S(Zagato) AM27", "AM27", 12, Induction.NormallyAspirated, 5935, 444, 7000, 630, 5500);
        }

        [TestMethod]
        public void Lookup_0_ReturnsExpectedValues()
        {
            var result = EngineRepository.Lookup('0', powerUnit, torqueUnit);
            TestValues(result, "Toyota 1NR-FE", "1NR-FE", 4, Induction.NormallyAspirated, 1329, 72, 6000, 121, 4000);
        }

        private void TestValues(
            vin.Engine actual,
            string expectedText,
            string expectedCode,
            int expectedCylinders,
            Induction expectedInduction,
            double expectedDisplacement,
            double? expectedPower,
            double? expectedPowerRpm,
            double? expectedTorque,
            double? expectedTorqueRpm,
            PowerUnit expectedPowerUnit = PowerUnit.Kw,
            TorqueUnit expectedTorqueUnit = TorqueUnit.Nm)
        {
            Assert.IsNotNull(actual);

            Assert.AreEqual(expectedText, actual.Text);

            Assert.AreEqual(expectedCode, actual.Code);
            Assert.AreEqual(expectedCylinders, actual.Cylinders);
            Assert.AreEqual(expectedInduction, actual.Induction);
            Assert.AreEqual(expectedDisplacement, actual.DisplacementInCc);
            Assert.AreEqual(expectedPower, actual.MaxPower);
            Assert.AreEqual(expectedPowerUnit, actual.MaxPowerUnit);
            Assert.AreEqual(expectedPowerRpm, actual.MaxPowerRpm);
            Assert.AreEqual(expectedTorque, actual.MaxTorque);
            Assert.AreEqual(expectedTorqueUnit, actual.MaxTorqueUnit);
            Assert.AreEqual(expectedTorqueRpm, actual.MaxTorqueRpm);
        }
    }
}
