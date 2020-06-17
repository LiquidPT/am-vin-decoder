// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using AmVinDecoderLib.Repositories;
using AmVinDecoderLib.VinComponents.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmVinDecoderLib.UnitTest.Repositories
{
    [TestClass]
    public class RestraintSystemRepositoryTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_SymbolVinCode_ThrowsException()
        {
            _ = RestraintSystemRepository.Lookup('*', null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_NumericVinCode_ThrowsException()
        {
            _ = RestraintSystemRepository.Lookup('1', null);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void Lookup_UnknownLetterVinCode_ThrowsException()
        {
            _ = RestraintSystemRepository.Lookup('X', null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_LetterModelYear_ThrowsException()
        {
            _ = RestraintSystemRepository.Lookup('A', "A");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_SymbolModelYear_ThrowsException()
        {
            _ = RestraintSystemRepository.Lookup('A', "*");
        }

        [TestMethod]
        public void Lookup_KnownLetterVinCode_ReturnsValue()
        {
            var result = RestraintSystemRepository.Lookup('A', null);
            Assert.IsNotNull(result.Text);
        }

        [TestMethod]
        public void Lookup_KnownLetterVinCodeAndNumericModelYear_ReturnsValue()
        {
            var result = RestraintSystemRepository.Lookup('A', "2014");
            Assert.IsNotNull(result.Text);
        }

        [TestMethod]
        public void Lookup_KnownLetterVinCodeAndTrueDB11Volante_ReturnsValue()
        {
            var result = RestraintSystemRepository.Lookup('R', null, ModelType.Db11Volante);
            Assert.IsNotNull(result.Text);
        }
    }
}
