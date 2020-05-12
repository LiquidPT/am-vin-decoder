using AmVinDecoderLib.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AmVinDecoderLib.UnitTest.Repositories
{
    [TestClass]
    public class ModelRepositoryTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_SymbolVinCode_ThrowsException()
        {
            _ = ModelRepository.Lookup('*', null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_NumericVinCode_ThrowsException()
        {
            _ = ModelRepository.Lookup('1', null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Lookup_UnknownLetterVinCode_ThrowsException()
        {
            var result = ModelRepository.Lookup('X', null);
            _ = result.Text;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_LetterSerialModifier_ThrowsException()
        {
            _ = ModelRepository.Lookup('A', 'A');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_SymbolSerialModifier_ThrowsException()
        {
            _ = ModelRepository.Lookup('A', '*');
        }

        [TestMethod]
        public void Lookup_KnownLetterVinCode_ReturnsValue()
        {
            _ = ModelRepository.Lookup('A', null);
        }

        [TestMethod]
        public void Lookup_KnownLetterVinCodeAndSerialModifier_ReturnsValue()
        {
            var result = ModelRepository.Lookup('E', '0');
            Assert.IsNotNull(result.Text);
        }
    }
}
