using AmVinDecoderLib.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AmVinDecoderLib.UnitTest.Repositories
{
    [TestClass]
    public class RestraintSystemRepositoryTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_SymbolVinCode_ThrowsException()
        {
            _ = RestraintSystemRepository.Lookup('*', null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_NumericVinCode_ThrowsException()
        {
            _ = RestraintSystemRepository.Lookup('1', null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Lookup_UnknownLetterVinCode_ThrowsException()
        {
            _ = RestraintSystemRepository.Lookup('X', null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_NumericModelCode_ThrowsException()
        {
            _ = RestraintSystemRepository.Lookup('A', null, '0');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_SymbolModelCode_ThrowsException()
        {
            _ = RestraintSystemRepository.Lookup('A', null, '*');
        }

        [TestMethod]
        public void Lookup_KnownLetterVinCode_ReturnsValue()
        {
            var result = RestraintSystemRepository.Lookup('A', null, null);
            Assert.IsNotNull(result.Text);
        }

        [TestMethod]
        public void Lookup_KnownLetterVinCodeAndNumericModelYear_ReturnsValue()
        {
            var result = RestraintSystemRepository.Lookup('A', "2014", null);
            Assert.IsNotNull(result.Text);
        }

        [TestMethod]
        public void Lookup_KnownLetterVinCodeAndLetterModelCode_ReturnsValue()
        {
            var result = RestraintSystemRepository.Lookup('A', null, 'A');
            Assert.IsNotNull(result.Text);
        }
    }
}
