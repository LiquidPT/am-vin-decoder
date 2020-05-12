using AmVinDecoderLib.VinComponents;
using AmVinDecoderLib.VinLookup;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AmVinDecoderLib.UnitTest.VinLookup
{
    [TestClass]
    public class SteeringLookupTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_SymbolVinCode_ThrowsException()
        {
            _ = SteeringLookup.Lookup('*');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_NumericVinCode_ThrowsException()
        {
            _ = SteeringLookup.Lookup('1');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Lookup_UnknownLetterVinCode_ThrowsException()
        {
            var result = SteeringLookup.Lookup('X');
            _ = result.Text;
        }

        [TestMethod]
        public void Lookup_KnownLetterVinCode_ReturnsValue()
        {
            var result = SteeringLookup.Lookup('A');
            Assert.IsNotNull(result.Text);
        }
    }
}
