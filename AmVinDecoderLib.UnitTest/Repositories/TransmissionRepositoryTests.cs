using AmVinDecoderLib.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AmVinDecoderLib.UnitTest.Repositories
{
    [TestClass]
    public class TransmissionRepositoryTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_SymbolVinCode_ThrowsException()
        {
            _ = TransmissionRepository.Lookup('*');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_NumericVinCode_ThrowsException()
        {
            _ = TransmissionRepository.Lookup('1');
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void Lookup_UnknownLetterVinCode_ThrowsException()
        {
            _ = TransmissionRepository.Lookup('X');
        }

        [TestMethod]
        public void Lookup_KnownLetterVinCode_ReturnsValue()
        {
            var result = TransmissionRepository.Lookup('A');
            Assert.IsNotNull(result.Text);
        }
    }
}
