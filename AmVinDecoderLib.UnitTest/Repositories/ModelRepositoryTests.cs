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
    public class ModelRepositoryTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_SymbolVinCode_ThrowsException()
        {
            _ = ModelRepository.Lookup('*', null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void Lookup_UnknownNumericVinCode_ThrowsException()
        {
            _ = ModelRepository.Lookup('1', null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void Lookup_UnknownLetterVinCode_ThrowsException()
        {
            var result = ModelRepository.Lookup('X', null, null);
            _ = result.Text;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_LetterSerialModifier_ThrowsException()
        {
            _ = ModelRepository.Lookup('A', null, 'A');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_SymbolSerialModifier_ThrowsException()
        {
            _ = ModelRepository.Lookup('A', null, '*');
        }

        [TestMethod]
        public void Lookup_KnownNumericVinCode_ReturnsValue()
        {
            _ = ModelRepository.Lookup('0', null, null);
        }

        [TestMethod]
        public void Lookup_KnownLetterVinCode_ReturnsValue()
        {
            _ = ModelRepository.Lookup('A', null, null);
        }

        [TestMethod]
        public void Lookup_KnownLetterVinCodeDefaultSerialModifier_ReturnsValue()
        {
            _ = ModelRepository.Lookup('E', null, null);
        }

        [TestMethod]
        public void Lookup_KnownLetterVinCodeAndSerialModifier_ReturnsValue()
        {
            var result = ModelRepository.Lookup('E', null, '0');
            Assert.IsNotNull(result.Text);
        }
    }
}
