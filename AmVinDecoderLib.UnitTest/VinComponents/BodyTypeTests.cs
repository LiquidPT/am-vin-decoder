using AmVinDecoderLib.VinComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AmVinDecoderLib.UnitTest.VinComponents
{
    [TestClass]
    public class BodyTypeTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Contructor_NullVinCode_ThrowsException()
        {
            _ = new BodyType(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Contructor_EmptyVinCode_ThrowsException()
        {
            _ = new BodyType(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Contructor_WhitespaceVinCode_ThrowsException()
        {
            _ = new BodyType("  ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Contructor_OneCharacterVinCode_ThrowsException()
        {
            _ = new BodyType("A");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Contructor_ThreeCharacterVinCode_ThrowsException()
        {
            _ = new BodyType("AAA");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Contructor_SymbolInVinCode_ThrowsException()
        {
            _ = new BodyType("*A");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Text_UnkonwnNumericVinCode_ThrowsException()
        {
            var result = new BodyType("00");
            _ = result.Text;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Text_UnknownLetterVinCode_ThrowsException()
        {
            var result = new BodyType("XX");
            _ = result.Text;
        }

        [TestMethod]
        public void Text_KnownNumericVinCode_ReturnsValue()
        {
            var result = new BodyType("01");
            Assert.IsNotNull(result.Text);
        }

        [TestMethod]
        public void Text_KnownLetterVinCode_ReturnsValue()
        {
            var result = new BodyType("AA");
            Assert.IsNotNull(result.Text);
        }
    }
}
