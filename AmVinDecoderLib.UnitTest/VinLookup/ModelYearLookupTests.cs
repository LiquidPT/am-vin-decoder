using AmVinDecoderLib.VinComponents;
using AmVinDecoderLib.VinLookup;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AmVinDecoderLib.UnitTest.VinLookup
{
    [TestClass]
    public class ModelYearLookupTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_SymbolVinCode_ThrowsException()
        {
            _ = ModelYearLookup.Lookup('*');
        }

        [TestMethod]
        public void Lookup_NumericVinCode_ReturnsValue()
        {
            var result = ModelYearLookup.Lookup('6');
            Assert.IsNotNull(result.Text);
            Assert.AreEqual("2006", result.Text);
        }

        [TestMethod]
        public void Lookup_FirstLetterVinCode_ReturnsValue()
        {
            var result = ModelYearLookup.Lookup('A');
            Assert.IsNotNull(result.Text);
            Assert.AreEqual("2010", result.Text);
        }

        [TestMethod]
        public void Lookup_LetterVinCode_ReturnsValue()
        {
            var result = ModelYearLookup.Lookup('D');
            Assert.IsNotNull(result.Text);
            Assert.AreEqual("2013", result.Text);
        }
    }
}
