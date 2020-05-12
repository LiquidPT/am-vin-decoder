using AmVinDecoderLib.VinComponents;
using AmVinDecoderLib.VinLookup;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AmVinDecoderLib.UnitTest.VinLookup
{
    [TestClass]
    public class SeatingLookupTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Lookup_NullVinCode_ThrowsException()
        {
            _ = SeatingLookup.Lookup(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Lookup_EmptyVinCode_ThrowsException()
        {
            _ = SeatingLookup.Lookup(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Lookup_WhitespaceVinCode_ThrowsException()
        {
            _ = SeatingLookup.Lookup("  ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_OneCharacterVinCode_ThrowsException()
        {
            _ = SeatingLookup.Lookup("A");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_ThreeCharacterVinCode_ThrowsException()
        {
            _ = SeatingLookup.Lookup("AAA");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_SymbolInVinCode_ThrowsException()
        {
            _ = SeatingLookup.Lookup("*A");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Lookup_UnkonwnNumericVinCode_ThrowsException()
        {
            _ = SeatingLookup.Lookup("00");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Lookup_UnknownLetterVinCode_ThrowsException()
        {
            _ = SeatingLookup.Lookup("XX");
        }

        [TestMethod]
        public void Lookup_KnownNumericVinCode_ReturnsValue()
        {
            var result = SeatingLookup.Lookup("01");
            Assert.IsNotNull(result.Text);
        }

        [TestMethod]
        public void Lookup_KnownLetterVinCode_ReturnsValue()
        {
            var result = SeatingLookup.Lookup("AA");
            Assert.IsNotNull(result.Text);
        }
    }
}
