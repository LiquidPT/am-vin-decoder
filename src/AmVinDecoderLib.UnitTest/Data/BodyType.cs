// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Repositories;
using AmVinDecoderLib.VinComponents.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using vin = AmVinDecoderLib.VinComponents;

namespace AmVinDecoderLib.UnitTest.Data
{
    [TestClass]
    public class BodyType
    {
        [TestMethod]
        public void Lookup_01_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("01");
            TestValues(result, "Coupe", 2, BodyStyle.Hatchback, SeatingConfiguration.TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_03_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("03");
            TestValues(result, "Coupe", 2, BodyStyle.Coupe, SeatingConfiguration.TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_02_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("02");
            TestValues(result, "Convertible", 2, BodyStyle.Convertible, SeatingConfiguration.TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_04_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("04");
            TestValues(result, "Convertible", 2, BodyStyle.Convertible, SeatingConfiguration.TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_05_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("05");
            TestValues(result, "DBS", 2, BodyStyle.Coupe, SeatingConfiguration.TwoPlusUnknown, null);
        }

        [TestMethod]
        public void Lookup_AA_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("AA");
            TestValues(result, "DB9 Coupe", 2, BodyStyle.Coupe, SeatingConfiguration.TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_AC_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("AC");
            TestValues(result, "DB9 Coupe", 2, BodyStyle.Coupe, SeatingConfiguration.TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_AB_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("AB");
            TestValues(result, "DB9 Convertible", 2, BodyStyle.Convertible, SeatingConfiguration.TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_AD_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("AD");
            TestValues(result, "DB9 Convertible", 2, BodyStyle.Convertible, SeatingConfiguration.TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_AE_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("AE");
            TestValues(result, "DB9 Coupe", 2, BodyStyle.Coupe, SeatingConfiguration.TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_AG_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("AG");
            TestValues(result, "DB9 Coupe", 2, BodyStyle.Coupe, SeatingConfiguration.TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_AF_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("AF");
            TestValues(result, "DB9 Convertible", 2, BodyStyle.Convertible, SeatingConfiguration.TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_AH_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("AH");
            TestValues(result, "DB9 Convertible", 2, BodyStyle.Convertible, SeatingConfiguration.TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_BA_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("BA");
            TestValues(result, "Vantage coupe", 2, BodyStyle.Hatchback, SeatingConfiguration.TwoSeats, 2);
        }

        [TestMethod]
        public void Lookup_BB_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("BB");
            TestValues(result, "Vantage roadster", 2, BodyStyle.Convertible, SeatingConfiguration.TwoSeats, 2);
        }

        [TestMethod]
        public void Lookup_BC_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("BC");
            TestValues(result, "V12 Vantage/S coupe", 2, BodyStyle.Hatchback, SeatingConfiguration.TwoSeats, 2);
        }

        [TestMethod]
        public void Lookup_BD_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("BD");
            TestValues(result, "Vantage S coupe", 2, BodyStyle.Hatchback, SeatingConfiguration.TwoSeats, 2);
        }

        [TestMethod]
        public void Lookup_BE_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("BE");
            TestValues(result, "Vantage S convertible", 2, BodyStyle.Convertible, SeatingConfiguration.TwoSeats, 2);
        }

        [TestMethod]
        public void Lookup_BF_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("BF");
            TestValues(result, "V12 Vantage/S convertible", 2, BodyStyle.Convertible, SeatingConfiguration.TwoSeats, 2);
        }

        [TestMethod]
        public void Lookup_BN_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("BN");
            TestValues(result, "V12VS w/ sports+ pack coupe", 2, BodyStyle.Hatchback, SeatingConfiguration.TwoSeats, 2);
        }

        [TestMethod]
        public void Lookup_BP_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("BP");
            TestValues(result, "V12VS w/ sports+ pack convertible", 2, BodyStyle.Convertible, SeatingConfiguration.TwoSeats, 2);
        }

        [TestMethod]
        public void Lookup_CA_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("CA");
            TestValues(result, "DBS Coupe", 2, BodyStyle.Coupe, SeatingConfiguration.TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_CB_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("CB");
            TestValues(result, "DBS Coupe", 2, BodyStyle.Coupe, SeatingConfiguration.TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_CC_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("CC");
            TestValues(result, "DBS convertible", 2, BodyStyle.Convertible, SeatingConfiguration.TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_CE_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("CE");
            TestValues(result, "Vanquish coupe", 2, BodyStyle.Coupe, SeatingConfiguration.TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_CF_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("CF");
            TestValues(result, "Vanquish coupe", 2, BodyStyle.Coupe, SeatingConfiguration.TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_CG_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("CG");
            TestValues(result, "Vanquish convertible", 2, BodyStyle.Convertible, SeatingConfiguration.TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_CH_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("CH");
            TestValues(result, "Vanquish convertible", 2, BodyStyle.Convertible, SeatingConfiguration.TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_CJ_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("CJ");
            TestValues(result, "Vanquish S coupe", 2, BodyStyle.Coupe, SeatingConfiguration.TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_CK_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("CK");
            TestValues(result, "Vanquish S coupe", 2, BodyStyle.Coupe, SeatingConfiguration.TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_CL_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("CL");
            TestValues(result, "Vanquish S convertible", 2, BodyStyle.Convertible, SeatingConfiguration.TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_CM_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("CM");
            TestValues(result, "Vanquish S convertible", 2, BodyStyle.Convertible, SeatingConfiguration.TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_CP_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("CP");
            TestValues(result, "Vanquish Zagato coupe", 2, BodyStyle.Coupe, SeatingConfiguration.TwoPlusUnknown, null);
        }

        [TestMethod]
        public void Lookup_CR_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("CR");
            TestValues(result, "Vanquish Zagato convertible", 2, BodyStyle.Convertible, SeatingConfiguration.TwoPlusUnknown, null);
        }

        [TestMethod]
        public void Lookup_CU_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("CU");
            TestValues(result, "Vanquish Zagato shooting brake", 2, BodyStyle.Hatchback, SeatingConfiguration.TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_DA_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("DA");
            TestValues(result, "Rapide", 4, BodyStyle.Sedan, SeatingConfiguration.FourSeats, 4);
        }

        [TestMethod]
        public void Lookup_DE_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("DE");
            TestValues(result, "Rapide S", 4, BodyStyle.Sedan, SeatingConfiguration.FourSeats, 4);
        }

        [TestMethod]
        public void Lookup_DF_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("DF");
            TestValues(result, "Rapide Shadow Ed", 4, BodyStyle.Sedan, SeatingConfiguration.FourSeats, 4);
        }

        [TestMethod]
        public void Lookup_EA_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("EA");
            TestValues(result, "Virage coupe", 2, BodyStyle.Coupe, SeatingConfiguration.TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_EC_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("EC");
            TestValues(result, "Virage coupe", 2, BodyStyle.Coupe, SeatingConfiguration.TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_EB_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("EB");
            TestValues(result, "Virage convertible", 2, BodyStyle.Convertible, SeatingConfiguration.TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_ED_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("ED");
            TestValues(result, "Virage convertible", 2, BodyStyle.Convertible, SeatingConfiguration.TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_FA_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("FA");
            TestValues(result, "DB11 coupe", 2, BodyStyle.Coupe, SeatingConfiguration.TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_FC_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("FC");
            TestValues(result, "DB11 convertible", 2, BodyStyle.Convertible, SeatingConfiguration.TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_FE_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("FE");
            TestValues(result, "DB11 AMR", 2, BodyStyle.Coupe, SeatingConfiguration.TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_GA_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("GA");
            TestValues(result, "New Vantage", 2, BodyStyle.Hatchback, SeatingConfiguration.TwoSeats, 2);
        }

        [TestMethod]
        public void Lookup_HA_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("HA");
            TestValues(result, "New DBS Coupe", 2, BodyStyle.Coupe, SeatingConfiguration.TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_HC_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("HC");
            TestValues(result, "New DBS Volante", 2, BodyStyle.Convertible, SeatingConfiguration.TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_JA_ReturnsExpectedValues()
        {
            var result = BodyTypeRepository.Lookup("JA");
            TestValues(result, "DBX", 5, BodyStyle.Suv, SeatingConfiguration.FiveSeats, 5);
        }

        private void TestValues(vin.BodyType actual, string expectedText, int expectedDoorCount, BodyStyle expectedBodyStyle, SeatingConfiguration expectedSeatingConfiguration, int? expectedSeatCount)
        {
            Assert.IsNotNull(actual);

            Assert.AreEqual(expectedText, actual.Text);
            Assert.AreEqual(expectedDoorCount, actual.DoorCount);
            Assert.AreEqual(expectedBodyStyle, actual.BodyStyle);
            Assert.AreEqual(expectedSeatingConfiguration, actual.SeatingConfiguration);
            Assert.AreEqual(expectedSeatCount, actual.SeatCount);
        }
    }
}
