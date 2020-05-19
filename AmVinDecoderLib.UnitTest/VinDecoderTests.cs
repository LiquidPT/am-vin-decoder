// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using AmVinDecoderLib.VinComponents.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmVinDecoderLib.UnitTest
{
    [TestClass]
    public class VinDecoderTests
    {
        private readonly UnitOptions unitOptions;

        public VinDecoderTests()
        {
            unitOptions = new UnitOptions
            {
                UseMetric = true,
                Power = PowerUnit.Bhp,
                Torque = TorqueUnit.LbFt,
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetInfo_NullVin_ThrowsException()
        {
            _ = VinDecoder.GetVehicleInfo("AAAAAAAAAAAAAAAAA", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetInfo_NullUnitOptions_ThrowsException()
        {
            _ = VinDecoder.GetVehicleInfo(null, unitOptions);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetInfo_EmptyVin_ThrowsException()
        {
            _ = VinDecoder.GetVehicleInfo(string.Empty, unitOptions);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetInfo_WhitespaceVin_ThrowsException()
        {
            _ = VinDecoder.GetVehicleInfo("  ", unitOptions);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetInfo_SixteenCharacterVin_ThrowsException()
        {
            _ = VinDecoder.GetVehicleInfo("AAAAAAAAAAAAAAAA", unitOptions);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetInfo_EighteenCharacterVin_ThrowsException()
        {
            _ = VinDecoder.GetVehicleInfo("AAAAAAAAAAAAAAAAAA", unitOptions);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetInfo_SymbolInVin_ThrowsException()
        {
            _ = VinDecoder.GetVehicleInfo("*AAAAAAAAAAAAAAAA", unitOptions);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetInfo_NonAstonMartinVin_ThrowsException()
        {
            _ = VinDecoder.GetVehicleInfo("AAAAAAAAAAAAAAAAA", unitOptions);
        }

        [TestMethod]
        public void GetInfo_V8VantageVin_ReturnsValue()
        {
            var result = VinDecoder.GetVehicleInfo("SCFEFBAK8BGC14779", unitOptions);
            Assert.IsNotNull(result);

            Assert.AreEqual("V8/V8S Coupe", result.Model.Text);
            Assert.IsFalse(result.Model.IsV12VantageS);
        }

        [TestMethod]
        public void GetInfo_DB9Vin_ReturnsValue()
        {
            var result = VinDecoder.GetVehicleInfo("SCFFDAAM5DGA14984", unitOptions);
            Assert.IsNotNull(result);

            Assert.AreEqual("DB9 Coupe", result.Model.Text);
            Assert.IsFalse(result.Model.IsV12VantageS);
        }

        [TestMethod]
        public void GetInfo_DBSVin_ReturnsValue()
        {
            var result = VinDecoder.GetVehicleInfo("SCFFDCBD5AGE02173", unitOptions);
            Assert.IsNotNull(result);

            Assert.AreEqual("DBS Coupe", result.Model.Text);
            Assert.IsFalse(result.Model.IsV12VantageS);
        }

        [TestMethod]
        public void GetInfo_VanquishZagatoVin_ReturnsValue()
        {
            var result = VinDecoder.GetVehicleInfo("SCFLMCPZ0JGJ33746", unitOptions);
            Assert.IsNotNull(result);

            Assert.AreEqual("Vanquish Zagato Coupe", result.Model.Text);
            Assert.IsFalse(result.Model.IsV12VantageS);
        }

        [TestMethod]
        public void GetInfo_V12VantageSVin_ReturnsValue()
        {
            var result = VinDecoder.GetVehicleInfo("SCFEKBCRXFGS01864", unitOptions);
            Assert.IsNotNull(result);

            Assert.AreEqual("V12 Vantage S Coupe", result.Model.Text);
            Assert.IsTrue(result.Model.IsV12VantageS);
        }

        [TestMethod]
        public void GetInfo_DB11Vin_ReturnsValue()
        {
            var result = VinDecoder.GetVehicleInfo("SCFRMFAVXHGL01520", unitOptions);
            Assert.IsNotNull(result);

            Assert.AreEqual("DB11 Coupe", result.Model.Text);
            Assert.IsFalse(result.Model.IsV12VantageS);
        }

        [TestMethod]
        public void GetInfo_VirageVin_ReturnsValue()
        {
            var result = VinDecoder.GetVehicleInfo("SCFFDECN9CGG13785", unitOptions);
            Assert.IsNotNull(result);

            Assert.AreEqual("Virage Coupe", result.Model.Text);
        }

        [TestMethod]
        public void GetInfo_NgDbsVin_ReturnsValue()
        {
            var result = VinDecoder.GetVehicleInfo("SCFRMHAV2KGR00947", unitOptions);
            Assert.IsNotNull(result);

            Assert.AreEqual("New DBS Coupe", result.Model.Text);
            Assert.IsFalse(result.Model.IsV12VantageS);
        }
    }
}
