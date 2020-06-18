// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using AmVinDecoderLib.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmVinDecoderLib.UnitTest.Utilities
{
    [TestClass]
    public class LookupUtilityTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidateLetterVinCode_SymbolVinCode_ThrowsException()
        {
            _ = LookupUtility.ValidateLetterVinCode('*');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidateLetterVinCode_NumericVinCode_ThrowsException()
        {
            _ = LookupUtility.ValidateLetterVinCode('1');
        }

        [TestMethod]
        public void ValidateLetterVinCode_LetterVinCode_ReturnsValue()
        {
            var result = LookupUtility.ValidateLetterVinCode('A');
            Assert.IsNotNull(result);
            Assert.AreEqual("A", result);
        }

        [TestMethod]
        public void ValidateLetterVinCode_LowerCaseVinCode_ReturnsUpperCaseValue()
        {
            var result = LookupUtility.ValidateLetterVinCode('a');
            Assert.IsNotNull(result);
            Assert.AreEqual("A", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ValidateLetterOrDigitVinCode_NullVinCode_ThrowsException()
        {
            _ = LookupUtility.ValidateLetterOrDigitVinCode(null, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateLetterOrDigitVinCode_EmptyVinCode_ThrowsException()
        {
            _ = LookupUtility.ValidateLetterOrDigitVinCode(string.Empty, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateLetterOrDigitVinCode_WhitespaceVinCode_ThrowsException()
        {
            _ = LookupUtility.ValidateLetterOrDigitVinCode("  ", 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidateLetterOrDigitVinCode_SymbolVinCode_ThrowsException()
        {
            _ = LookupUtility.ValidateLetterOrDigitVinCode("A*", 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateLetterOrDigitVinCode_WrongLengthVinCode_ThrowsException()
        {
            _ = LookupUtility.ValidateLetterOrDigitVinCode("AA", 3);
        }

        [TestMethod]
        public void ValidateLetterOrDigitVinCode_LetterVinCode_ReturnsValue()
        {
            var result = LookupUtility.ValidateLetterOrDigitVinCode("AA", 2);
            Assert.IsNotNull(result);
            Assert.AreEqual("AA", result);
        }

        [TestMethod]
        public void ValidateLetterOrDigitVinCode_NumberVinCode_ReturnsValue()
        {
            var result = LookupUtility.ValidateLetterOrDigitVinCode("11", 2);
            Assert.IsNotNull(result);
            Assert.AreEqual("11", result);
        }

        [TestMethod]
        public void ValidateLetterOrDigitVinCode_MixedVinCode_ReturnsValue()
        {
            var result = LookupUtility.ValidateLetterOrDigitVinCode("A1", 2);
            Assert.IsNotNull(result);
            Assert.AreEqual("A1", result);
        }

        [TestMethod]
        public void ValidateLetterOrDigitVinCode_LowerCaseVinCode_ReturnsUpperCaseValue()
        {
            var result = LookupUtility.ValidateLetterOrDigitVinCode("ab", 2);
            Assert.IsNotNull(result);
            Assert.AreEqual("AB", result);
        }
    }
}
