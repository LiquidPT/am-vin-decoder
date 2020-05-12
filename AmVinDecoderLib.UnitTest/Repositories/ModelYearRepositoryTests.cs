using AmVinDecoderLib.VinComponents;
using AmVinDecoderLib.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AmVinDecoderLib.UnitTest.Repositories
{
    [TestClass]
    public class ModelYearRepositoryTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_SymbolVinCode_ThrowsException()
        {
            _ = ModelYearRepository.Lookup('*');
        }

        [TestMethod]
        public void Lookup_NumericVinCode_ReturnsValue()
        {
            var result = ModelYearRepository.Lookup('6');
            Assert.IsNotNull(result.Text);
            Assert.AreEqual("2006", result.Text);
        }

        [TestMethod]
        public void Lookup_FirstLetterVinCode_ReturnsValue()
        {
            var result = ModelYearRepository.Lookup('A');
            Assert.IsNotNull(result.Text);
            Assert.AreEqual("2010", result.Text);
        }

        [TestMethod]
        public void Lookup_LetterVinCode_ReturnsValue()
        {
            var result = ModelYearRepository.Lookup('D');
            Assert.IsNotNull(result.Text);
            Assert.AreEqual("2013", result.Text);
        }
    }
}
