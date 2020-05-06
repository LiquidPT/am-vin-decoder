using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AmVinDecoderLib.UnitTest
{
    [TestClass]
    public class VinDecoderTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetInfo_NullVin_ThrowsException()
        {
            _ = VinDecoder.GetVehicleInfo(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetInfo_EmptyVin_ThrowsException()
        {
            _ = VinDecoder.GetVehicleInfo(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetInfo_WhitespaceVin_ThrowsException()
        {
            _ = VinDecoder.GetVehicleInfo("  ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetInfo_SixteenCharacterVin_ThrowsException()
        {
            _ = VinDecoder.GetVehicleInfo("AAAAAAAAAAAAAAAA");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetInfo_EighteenCharacterVin_ThrowsException()
        {
            _ = VinDecoder.GetVehicleInfo("AAAAAAAAAAAAAAAAAA");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetInfo_SymbolInVin_ThrowsException()
        {
            _ = VinDecoder.GetVehicleInfo("*AAAAAAAAAAAAAAAA");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetInfo_NonAstonMartinVin_ThrowsException()
        {
            _ = VinDecoder.GetVehicleInfo("AAAAAAAAAAAAAAAAA");
        }

        [TestMethod]
        public void GetInfo_V8VantageVin_ReturnsValue()
        {
            var result = VinDecoder.GetVehicleInfo("SCFEFBAK8BGC14779");
            Assert.IsNotNull(result);

            Assert.AreEqual("V8/V8S Coupe", result.Model.Text);
            Assert.IsFalse(result.Model.IsV12VantageS);
        }

        [TestMethod]
        public void GetInfo_DB9Vin_ReturnsValue()
        {
            var result = VinDecoder.GetVehicleInfo("SCFFDAAM5DGA14984");
            Assert.IsNotNull(result);

            Assert.AreEqual("DB9 Coupe", result.Model.Text);
            Assert.IsFalse(result.Model.IsV12VantageS);
        }

        [TestMethod]
        public void GetInfo_DBSVin_ReturnsValue()
        {
            var result = VinDecoder.GetVehicleInfo("SCFFDCBD5AGE02173");
            Assert.IsNotNull(result);

            Assert.AreEqual("DBS Coupe", result.Model.Text);
            Assert.IsFalse(result.Model.IsV12VantageS);
        }

        [TestMethod]
        public void GetInfo_VanquishZagatoVin_ReturnsValue()
        {
            var result = VinDecoder.GetVehicleInfo("SCFLMCPZ0JGJ33746");
            Assert.IsNotNull(result);

            Assert.AreEqual("Vanquish Zagato Coupe", result.Model.Text);
            Assert.IsFalse(result.Model.IsV12VantageS);
        }

        [TestMethod]
        public void GetInfo_V12VantageSVin_ReturnsValue()
        {
            var result = VinDecoder.GetVehicleInfo("SCFEKBCRXFGS01864");
            Assert.IsNotNull(result);

            Assert.AreEqual("V12 Vantage S Coupe", result.Model.Text);
            Assert.IsTrue(result.Model.IsV12VantageS);
        }

        [TestMethod]
        public void GetInfo_DB11Vin_ReturnsValue()
        {
            var result = VinDecoder.GetVehicleInfo("SCFRMFAVXHGL01520");
            Assert.IsNotNull(result);

            Assert.AreEqual("DB11 Coupe", result.Model.Text);
            Assert.IsFalse(result.Model.IsV12VantageS);
        }

        [TestMethod]
        public void GetInfo_VirageVin_ReturnsValue()
        {
            var result = VinDecoder.GetVehicleInfo("SCFFDECN9CGG13785");
            Assert.IsNotNull(result);

            Assert.AreEqual("Virage Coupe", result.Model.Text);
        }
    }
}
