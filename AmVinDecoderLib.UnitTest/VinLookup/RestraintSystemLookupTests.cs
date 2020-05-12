using AmVinDecoderLib.VinComponents;
using AmVinDecoderLib.VinLookup;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AmVinDecoderLib.UnitTest.VinLookup
{
    [TestClass]
    public class RestraintSystemLookupTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_SymbolVinCode_ThrowsException()
        {
            _ = RestraintSystemLookup.Lookup('*', null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_NumericVinCode_ThrowsException()
        {
            _ = RestraintSystemLookup.Lookup('1', null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Lookup_UnknownLetterVinCode_ThrowsException()
        {
            _ = RestraintSystemLookup.Lookup('X', null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_NumericModelCode_ThrowsException()
        {
            _ = RestraintSystemLookup.Lookup('A', null, '0');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_SymbolModelCode_ThrowsException()
        {
            _ = RestraintSystemLookup.Lookup('A', null, '*');
        }

        [TestMethod]
        public void Lookup_KnownLetterVinCode_ReturnsValue()
        {
            var result = RestraintSystemLookup.Lookup('A', null, null);
            Assert.IsNotNull(result.Text);
        }

        [TestMethod]
        public void Lookup_KnownLetterVinCodeAndNumericModelYear_ReturnsValue()
        {
            var result = RestraintSystemLookup.Lookup('A', "2014", null);
            Assert.IsNotNull(result.Text);
        }

        [TestMethod]
        public void Lookup_KnownLetterVinCodeAndLetterModelCode_ReturnsValue()
        {
            var result = RestraintSystemLookup.Lookup('A', null, 'A');
            Assert.IsNotNull(result.Text);
        }
    }
}
