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
    public class Seating
    {
        private const string TwoPlusTwo = "2+2";
        private const string TwoPlusZero = "2+0";
        private const string TwoPlusUnknown = "2+0 or 2+2";
        private const string TwoSeats = "2 seats";
        private const string FourSeats = "4 seats";

        [TestMethod]
        public void Lookup_01_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("01");
            TestValues(result, TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_03_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("03");
            TestValues(result, TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_02_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("02");
            TestValues(result, TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_04_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("04");
            TestValues(result, TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_05_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("05");
            TestValues(result, TwoPlusUnknown, null);
        }

        [TestMethod]
        public void Lookup_AA_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("AA");
            TestValues(result, TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_AC_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("AC");
            TestValues(result, TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_AB_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("AB");
            TestValues(result, TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_AD_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("AD");
            TestValues(result, TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_AE_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("AE");
            TestValues(result, TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_AG_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("AG");
            TestValues(result, TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_AF_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("AF");
            TestValues(result, TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_AH_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("AH");
            TestValues(result, TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_BA_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("BA");
            TestValues(result, TwoSeats, 2);
        }

        [TestMethod]
        public void Lookup_BB_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("BB");
            TestValues(result, TwoSeats, 2);
        }

        [TestMethod]
        public void Lookup_BC_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("BC");
            TestValues(result, TwoSeats, 2);
        }

        [TestMethod]
        public void Lookup_BD_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("BD");
            TestValues(result, TwoSeats, 2);
        }

        [TestMethod]
        public void Lookup_BE_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("BE");
            TestValues(result, TwoSeats, 2);
        }

        [TestMethod]
        public void Lookup_BF_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("BF");
            TestValues(result, TwoSeats, 2);
        }

        [TestMethod]
        public void Lookup_BN_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("BN");
            TestValues(result, TwoSeats, 2);
        }

        [TestMethod]
        public void Lookup_BP_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("BP");
            TestValues(result, TwoSeats, 2);
        }

        [TestMethod]
        public void Lookup_CA_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CA");
            TestValues(result, TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_CB_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CB");
            TestValues(result, TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_CC_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CC");
            TestValues(result, TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_CE_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CE");
            TestValues(result, TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_CF_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CF");
            TestValues(result, TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_CG_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CG");
            TestValues(result, TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_CH_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CH");
            TestValues(result, TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_CJ_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CJ");
            TestValues(result, TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_CK_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CK");
            TestValues(result, TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_CL_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CL");
            TestValues(result, TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_CM_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CM");
            TestValues(result, TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_CP_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CP");
            TestValues(result, TwoPlusUnknown, null);
        }

        [TestMethod]
        public void Lookup_CR_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CR");
            TestValues(result, TwoPlusUnknown, null);
        }

        [TestMethod]
        public void Lookup_DA_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("DA");
            TestValues(result, FourSeats, 4);
        }

        [TestMethod]
        public void Lookup_DE_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("DE");
            TestValues(result, FourSeats, 4);
        }

        [TestMethod]
        public void Lookup_DF_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("DF");
            TestValues(result, FourSeats, 4);
        }

        [TestMethod]
        public void Lookup_EA_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("EA");
            TestValues(result, TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_EC_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("EC");
            TestValues(result, TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_EB_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("EB");
            TestValues(result, TwoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_ED_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("ED");
            TestValues(result, TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_FA_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("FA");
            TestValues(result, TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_FC_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("FC");
            TestValues(result, TwoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_GA_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("GA");
            TestValues(result, TwoSeats, 2);
        }

        [TestMethod]
        public void Lookup_HA_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("HA");
            TestValues(result, TwoPlusTwo, 4);
        }

        private void TestValues(vin.Seating actual, string expectedText, int? expectedSeatCount)
        {
            Assert.IsNotNull(actual);

            Assert.AreEqual(expectedText, actual.Text);
            Assert.AreEqual(expectedSeatCount, actual.SeatCount);
        }
    }
}
