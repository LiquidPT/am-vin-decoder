using AmVinDecoderLib.VinComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AmVinDecoderLib.UnitTest.VinComponents
{
    [TestClass]
    public class FactoryTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Contructor_SymbolVinCode_ThrowsException()
        {
            _ = new Factory('*');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Contructor_NumericVinCode_ThrowsException()
        {
            _ = new Factory('1');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Text_UnknownLetterVinCode_ThrowsException()
        {
            var result = new Factory('X');
            _ = result.Text;
        }

        [TestMethod]
        public void Text_KnownLetterVinCode_ReturnsValue()
        {
            var result = new Factory('A');
            Assert.IsNotNull(result.Text);
        }
    }
}
