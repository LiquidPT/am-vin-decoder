// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Utilities;
using EnsureThat;

namespace AmVinDecoderLib.UnitTest.Utilities;

[TestClass]
public class EnsureThatValueTypeExtensionTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void IsAlphaNumeric_Symbol_ThrowsException()
    {
        Ensure.That<char>('*').IsAlphaNumeric();
    }

    [TestMethod]
    public void IsAlphaNumeric_Letter_ReturnsOk()
    {
        Ensure.That<char>('A').IsAlphaNumeric();
    }

    [TestMethod]
    public void IsAlphaNumeric_Number_ReturnsOk()
    {
        Ensure.That<char>('1').IsAlphaNumeric();
    }

    [TestMethod]
    public void IsAlphaNumeric_LowerCase_ReturnsOk()
    {
        Ensure.That<char>('a').IsAlphaNumeric();
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void IsAlpha_Symbol_ThrowsException()
    {
        Ensure.That<char>('*').IsAlpha();
    }

    [TestMethod]
    public void IsAlpha_Letter_ReturnsOk()
    {
        Ensure.That<char>('A').IsAlpha();
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void IsAlpha_Number_ThrowsException()
    {
        Ensure.That<char>('1').IsAlpha();
    }

    [TestMethod]
    public void IsAlpha_LowerCase_ReturnsOk()
    {
        Ensure.That<char>('a').IsAlpha();
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void IsNumeric_Symbol_ThrowsException()
    {
        Ensure.That<char>('*').IsNumeric();
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void IsNumeric_Letter_ThrowsException()
    {
        Ensure.That<char>('A').IsNumeric();
    }

    [TestMethod]
    public void IsNumeric_Number_ReturnsOk()
    {
        Ensure.That<char>('1').IsNumeric();
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void IsNumeric_LowerCase_ThrowsException()
    {
        Ensure.That<char>('a').IsNumeric();
    }
}
