using AmVinDecoderLib.VinComponents;
using AmVinDecoderLib.VinLookup;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AmVinDecoderLib.UnitTest.VinLookup
{
    [TestClass]
    public class ModelLookupTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_SymbolVinCode_ThrowsException()
        {
            _ = ModelLookup.Lookup('*', null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_NumericVinCode_ThrowsException()
        {
            _ = ModelLookup.Lookup('1', null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Lookup_UnknownLetterVinCode_ThrowsException()
        {
            var result = ModelLookup.Lookup('X', null);
            _ = result.Text;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_LetterSerialModifier_ThrowsException()
        {
            _ = ModelLookup.Lookup('A', 'A');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_SymbolSerialModifier_ThrowsException()
        {
            _ = ModelLookup.Lookup('A', '*');
        }

        [TestMethod]
        public void Lookup_KnownLetterVinCode_ReturnsValue()
        {
            _ = ModelLookup.Lookup('A', null);
        }

        [TestMethod]
        public void Lookup_KnownLetterVinCodeAndSerialModifier_ReturnsValue()
        {
            var result = ModelLookup.Lookup('E', '0');
            Assert.IsNotNull(result.Text);
        }
    }
}
