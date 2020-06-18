// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using AmVinDecoderLib.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmVinDecoderLib.UnitTest.Repositories
{
    [TestClass]
    public class SeatingRepositoryTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Lookup_NullVinCode_ThrowsException()
        {
            _ = SeatingRepository.Lookup(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Lookup_EmptyVinCode_ThrowsException()
        {
            _ = SeatingRepository.Lookup(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Lookup_WhitespaceVinCode_ThrowsException()
        {
            _ = SeatingRepository.Lookup("  ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Lookup_OneCharacterVinCode_ThrowsException()
        {
            _ = SeatingRepository.Lookup("A");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Lookup_ThreeCharacterVinCode_ThrowsException()
        {
            _ = SeatingRepository.Lookup("AAA");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_SymbolInVinCode_ThrowsException()
        {
            _ = SeatingRepository.Lookup("*A");
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void Lookup_UnkonwnNumericVinCode_ThrowsException()
        {
            _ = SeatingRepository.Lookup("00");
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void Lookup_UnknownLetterVinCode_ThrowsException()
        {
            _ = SeatingRepository.Lookup("XX");
        }

        [TestMethod]
        public void Lookup_KnownNumericVinCode_ReturnsValue()
        {
            var result = SeatingRepository.Lookup("01");
            Assert.IsNotNull(result.Text);
        }

        [TestMethod]
        public void Lookup_KnownLetterVinCode_ReturnsValue()
        {
            var result = SeatingRepository.Lookup("AA");
            Assert.IsNotNull(result.Text);
        }
    }
}
