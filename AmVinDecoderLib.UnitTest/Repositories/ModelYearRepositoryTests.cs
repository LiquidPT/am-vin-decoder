// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using AmVinDecoderLib.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmVinDecoderLib.UnitTest.Repositories
{
    [TestClass]
    public class ModelYearRepositoryTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lookup_SymbolVinCode_ThrowsException()
        {
            _ = ModelYearRepository.Lookup('*');
        }

        [TestMethod]
        public void Lookup_NumericVinCode_ReturnsValue()
        {
            var result = ModelYearRepository.Lookup('6');
            Assert.IsNotNull(result.Text);
            Assert.AreEqual("2006", result.Text);
        }

        [TestMethod]
        public void Lookup_FirstLetterVinCode_ReturnsValue()
        {
            var result = ModelYearRepository.Lookup('A');
            Assert.IsNotNull(result.Text);
            Assert.AreEqual("2010", result.Text);
        }

        [TestMethod]
        public void Lookup_LetterVinCode_ReturnsValue()
        {
            var result = ModelYearRepository.Lookup('D');
            Assert.IsNotNull(result.Text);
            Assert.AreEqual("2013", result.Text);
        }

        [TestMethod]
        public void Lookup_H_ReturnsCorrectValue()
        {
            var result = ModelYearRepository.Lookup('H');
            Assert.IsNotNull(result.Text);
            Assert.AreEqual("2017", result.Text);
        }

        [TestMethod]
        public void Lookup_J_ReturnsCorrectValue()
        {
            var result = ModelYearRepository.Lookup('J');
            Assert.IsNotNull(result.Text);
            Assert.AreEqual("2018", result.Text);
        }
    }
}
