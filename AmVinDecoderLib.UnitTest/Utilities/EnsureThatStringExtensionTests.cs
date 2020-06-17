// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using AmVinDecoderLib.Utilities;
using EnsureThat;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmVinDecoderLib.UnitTest.Utilities
{
    [TestClass]
    public class EnsureThatStringExtensionTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsAlphaNumeric_Null_ThrowsException()
        {
            Ensure.That(null).IsAlphaNumeric();
        }

        [TestMethod]
        public void IsAlphaNumeric_Empty_ReturnsOk()
        {
            Ensure.That(string.Empty).IsAlphaNumeric();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsAlphaNumeric_Whitespace_ThrowsException()
        {
            Ensure.That("  ").IsAlphaNumeric();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsAlphaNumeric_Symbol_ThrowsException()
        {
            Ensure.That("A*").IsAlphaNumeric();
        }

        [TestMethod]
        public void IsAlphaNumeric_Letter_ReturnsOk()
        {
            Ensure.That("AA").IsAlphaNumeric();
        }

        [TestMethod]
        public void IsAlphaNumeric_Number_ReturnsOk()
        {
            Ensure.That("11").IsAlphaNumeric();
        }

        [TestMethod]
        public void IsAlphaNumeric_Mixed_ReturnsOk()
        {
            Ensure.That("A1").IsAlphaNumeric();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsAlpha_Null_ThrowsException()
        {
            Ensure.That(null).IsAlpha();
        }

        [TestMethod]
        public void IsAlpha_Empty_ReturnsOk()
        {
            Ensure.That(string.Empty).IsAlpha();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsAlpha_Whitespace_ThrowsException()
        {
            Ensure.That("  ").IsAlpha();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsAlpha_Symbol_ThrowsException()
        {
            Ensure.That("A*").IsAlpha();
        }

        [TestMethod]
        public void IsAlpha_Letter_ReturnsOk()
        {
            Ensure.That("AA").IsAlpha();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsAlpha_Number_ThrowsException()
        {
            Ensure.That("11").IsAlpha();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsAlpha_Mixed_ThrowsException()
        {
            Ensure.That("A1").IsAlpha();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsNumeric_Null_ThrowsException()
        {
            Ensure.That(null).IsNumeric();
        }

        [TestMethod]
        public void IsNumeric_Empty_ReturnsOk()
        {
            Ensure.That(string.Empty).IsNumeric();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsNumeric_Whitespace_ThrowsException()
        {
            Ensure.That("  ").IsNumeric();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsNumeric_Symbol_ThrowsException()
        {
            Ensure.That("A*").IsNumeric();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsNumeric_Letter_ThrowsException()
        {
            Ensure.That("AA").IsNumeric();
        }

        [TestMethod]
        public void IsNumeric_Number_ReturnsOk()
        {
            Ensure.That("11").IsNumeric();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsNumeric_Mixed_ThrowsException()
        {
            Ensure.That("A1").IsNumeric();
        }

        [TestMethod]
        public void IsNullOrNumeric_Null_ReturnsOk()
        {
            Ensure.That(null).IsNullOrNumeric();
        }

        [TestMethod]
        public void IsNullOrNumeric_Empty_ReturnsOk()
        {
            Ensure.That(string.Empty).IsNullOrNumeric();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsNullOrNumeric_Whitespace_ThrowsException()
        {
            Ensure.That("  ").IsNullOrNumeric();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsNullOrNumeric_Symbol_ThrowsException()
        {
            Ensure.That("A*").IsNullOrNumeric();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsNullOrNumeric_Letter_ThrowsException()
        {
            Ensure.That("AA").IsNullOrNumeric();
        }

        [TestMethod]
        public void IsNullOrNumeric_Number_ReturnsOk()
        {
            Ensure.That("11").IsNullOrNumeric();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsNullOrNumeric_Mixed_ThrowsException()
        {
            Ensure.That("A1").IsNullOrNumeric();
        }
    }
}
