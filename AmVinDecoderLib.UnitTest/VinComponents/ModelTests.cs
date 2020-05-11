using AmVinDecoderLib.VinComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AmVinDecoderLib.UnitTest.VinComponents
{
    [TestClass]
    public class ModelTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Contructor_SymbolVinCode_ThrowsException()
        {
            _ = new Model('*', null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Contructor_NumericVinCode_ThrowsException()
        {
            _ = new Model('1', null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Text_UnknownLetterVinCode_ThrowsException()
        {
            var result = new Model('X', null);
            _ = result.Text;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Contructor_LetterSerialModifier_ThrowsException()
        {
            _ = new Model('A', 'A');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Contructor_SymbolSerialModifier_ThrowsException()
        {
            _ = new Model('A', '*');
        }

        [TestMethod]
        public void Text_KnownLetterVinCode_ReturnsValue()
        {
            var result = new Model('A', null);
            Assert.IsNotNull(result.Text);
        }

        [TestMethod]
        public void Text_KnownLetterVinCodeAndSerialModifier_ReturnsValue()
        {
            var result = new Model('E', '0');
            Assert.IsNotNull(result.Text);
        }
    }
}
