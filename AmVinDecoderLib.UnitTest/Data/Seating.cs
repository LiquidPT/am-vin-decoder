using AmVinDecoderLib.Repositories;
using AmVinDecoderLib.VinComponents.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using vin = AmVinDecoderLib.VinComponents;

namespace AmVinDecoderLib.UnitTest.Data
{
    [TestClass]
    public class Seating
    {
        private const string twoPlusTwo = "2+2";
        private const string twoPlusZero = "2+0";
        private const string twoPlusUnknown = "2+0 or 2+2";
        private const string twoSeats = "2 seats";
        private const string fourSeats = "4 seats";

        [TestMethod]
        public void Lookup_01_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("01");
            TestValues(result, twoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_03_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("03");
            TestValues(result, twoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_02_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("02");
            TestValues(result, twoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_04_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("04");
            TestValues(result, twoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_05_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("05");
            TestValues(result, twoPlusUnknown, null);
        }

        [TestMethod]
        public void Lookup_AA_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("AA");
            TestValues(result, twoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_AC_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("AC");
            TestValues(result, twoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_AB_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("AB");
            TestValues(result, twoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_AD_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("AD");
            TestValues(result, twoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_AE_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("AE");
            TestValues(result, twoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_AG_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("AG");
            TestValues(result, twoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_AF_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("AF");
            TestValues(result, twoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_AH_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("AH");
            TestValues(result, twoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_BA_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("BA");
            TestValues(result, twoSeats, 2);
        }

        [TestMethod]
        public void Lookup_BB_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("BB");
            TestValues(result, twoSeats, 2);
        }

        [TestMethod]
        public void Lookup_BC_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("BC");
            TestValues(result, twoSeats, 2);
        }

        [TestMethod]
        public void Lookup_BD_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("BD");
            TestValues(result, twoSeats, 2);
        }

        [TestMethod]
        public void Lookup_BE_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("BE");
            TestValues(result, twoSeats, 2);
        }

        [TestMethod]
        public void Lookup_BF_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("BF");
            TestValues(result, twoSeats, 2);
        }

        [TestMethod]
        public void Lookup_BN_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("BN");
            TestValues(result, twoSeats, 2);
        }

        [TestMethod]
        public void Lookup_BP_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("BP");
            TestValues(result, twoSeats, 2);
        }

        [TestMethod]
        public void Lookup_CA_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CA");
            TestValues(result, twoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_CB_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CB");
            TestValues(result, twoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_CC_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CC");
            TestValues(result, twoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_CE_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CE");
            TestValues(result, twoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_CF_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CF");
            TestValues(result, twoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_CG_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CG");
            TestValues(result, twoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_CH_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CH");
            TestValues(result, twoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_CJ_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CJ");
            TestValues(result, twoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_CK_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CK");
            TestValues(result, twoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_CL_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CL");
            TestValues(result, twoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_CM_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CM");
            TestValues(result, twoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_CP_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CP");
            TestValues(result, twoPlusUnknown, null);
        }

        [TestMethod]
        public void Lookup_CR_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("CR");
            TestValues(result, twoPlusUnknown, null);
        }

        [TestMethod]
        public void Lookup_DA_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("DA");
            TestValues(result, fourSeats, 4);
        }

        [TestMethod]
        public void Lookup_DE_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("DE");
            TestValues(result, fourSeats, 4);
        }

        [TestMethod]
        public void Lookup_DF_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("DF");
            TestValues(result, fourSeats, 4);
        }

        [TestMethod]
        public void Lookup_EA_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("EA");
            TestValues(result, twoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_EC_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("EC");
            TestValues(result, twoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_EB_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("EB");
            TestValues(result, twoPlusZero, 2);
        }

        [TestMethod]
        public void Lookup_ED_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("ED");
            TestValues(result, twoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_FA_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("FA");
            TestValues(result, twoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_FC_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("FC");
            TestValues(result, twoPlusTwo, 4);
        }

        [TestMethod]
        public void Lookup_GA_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("GA");
            TestValues(result, twoSeats, 2);
        }

        [TestMethod]
        public void Lookup_HA_ReturnsExpectedValues()
        {
            var result = SeatingRepository.Lookup("HA");
            TestValues(result, twoPlusTwo, 4);
        }

        private void TestValues(vin.Seating actual, string expectedText, int? expectedSeatCount)
        {
            Assert.IsNotNull(actual);

            Assert.AreEqual(expectedText, actual.Text);
            //Assert.AreEqual(expectedSeatCount, actual.SeatCount);
        }
    }
}
