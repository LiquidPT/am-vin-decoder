using AmVinDecoderLib.VinComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AmVinDecoderLib.UnitTest.VinComponents
{
    [TestClass]
    public class RestraintSystemTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Contructor_SymbolVinCode_ThrowsException()
        {
            _ = new RestraintSystem('*', null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Contructor_NumericVinCode_ThrowsException()
        {
            _ = new RestraintSystem('1', null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Text_UnknownLetterVinCode_ThrowsException()
        {
            var result = new RestraintSystem('X', null, null);
            _ = result.Text;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Contructor_NumericModelCode_ThrowsException()
        {
            _ = new RestraintSystem('A', null, '0');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Contructor_SymbolModelCode_ThrowsException()
        {
            _ = new RestraintSystem('A', null, '*');
        }

        [TestMethod]
        public void Text_KnownLetterVinCode_ReturnsValue()
        {
            var result = new RestraintSystem('A', null, null);
            Assert.IsNotNull(result.Text);
        }

        [TestMethod]
        public void Text_KnownLetterVinCodeAndNumericModelYear_ReturnsValue()
        {
            var result = new RestraintSystem('A', "2014", null);
            Assert.IsNotNull(result.Text);
        }

        [TestMethod]
        public void Text_KnownLetterVinCodeAndLetterModelCode_ReturnsValue()
        {
            var result = new RestraintSystem('A', null, 'A');
            Assert.IsNotNull(result.Text);
        }
    }
}
