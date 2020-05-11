using AmVinDecoderLib.VinComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AmVinDecoderLib.UnitTest.VinComponents
{
    [TestClass]
    public class SteeringTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Contructor_SymbolVinCode_ThrowsException()
        {
            _ = new Steering('*');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Contructor_NumericVinCode_ThrowsException()
        {
            _ = new Steering('1');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Text_UnknownLetterVinCode_ThrowsException()
        {
            var result = new Steering('X');
            _ = result.Text;
        }

        [TestMethod]
        public void Text_KnownLetterVinCode_ReturnsValue()
        {
            var result = new Steering('A');
            Assert.IsNotNull(result.Text);
        }
    }
}
