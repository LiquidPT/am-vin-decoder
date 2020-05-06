using AmVinDecoderLib.VinComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AmVinDecoderLib.UnitTest.VinComponents
{
    [TestClass]
    public class ModelYearTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Contructor_SymbolVinCode_ThrowsException()
        {
            _ = new ModelYear('*');
        }

        [TestMethod]
        public void Contructor_NumericVinCode_ReturnsValue()
        {
            var result = new ModelYear('6');
            Assert.IsNotNull(result.Text);
            Assert.AreEqual("2006", result.Text);
        }

        [TestMethod]
        public void Contructor_FirstLetterVinCode_ReturnsValue()
        {
            var result = new ModelYear('A');
            Assert.IsNotNull(result.Text);
            Assert.AreEqual("2010", result.Text);
        }

        [TestMethod]
        public void Contructor_LetterVinCode_ReturnsValue()
        {
            var result = new ModelYear('D');
            Assert.IsNotNull(result.Text);
            Assert.AreEqual("2013", result.Text);
        }
    }
}
