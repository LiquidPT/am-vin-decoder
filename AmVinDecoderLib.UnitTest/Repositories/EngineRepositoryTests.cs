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
    public class EngineRepositoryTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_SymbolVinCode_ThrowsException()
        {
            _ = EngineRepository.Lookup('*', PowerUnit.Bhp, TorqueUnit.LbFt);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_NumericVinCode_ThrowsException()
        {
            _ = EngineRepository.Lookup('1', PowerUnit.Bhp, TorqueUnit.LbFt);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void Lookup_UnknownLetterVinCode_ThrowsException()
        {
            _ = EngineRepository.Lookup('X', PowerUnit.Bhp, TorqueUnit.LbFt);
        }

        [TestMethod]
        public void Lookup_KnownLetterVinCode_ReturnsValue()
        {
            var result = EngineRepository.Lookup('A', PowerUnit.Bhp, TorqueUnit.LbFt);
            Assert.IsNotNull(result.Text);
        }
    }
}
