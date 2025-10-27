// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Utilities;

namespace AmVinDecoderLib.UnitTest.Utilities;

[TestClass]
public class ArgumentOutOfRangeExceptionExtensionTests
{
    #region String parameter

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void StringIsAlphaNumeric_Null_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlphaNumeric((string)null);
    }

    [TestMethod]
    public void StringIsAlphaNumeric_Empty_ReturnsOk()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlphaNumeric(string.Empty);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void StringIsAlphaNumeric_Whitespace_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlphaNumeric("  ");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void StringIsAlphaNumeric_Symbol_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlphaNumeric("A*");
    }

    [TestMethod]
    public void StringIsAlphaNumeric_Letter_ReturnsOk()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlphaNumeric("AA");
    }

    [TestMethod]
    public void StringIsAlphaNumeric_Number_ReturnsOk()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlphaNumeric("11");
    }

    [TestMethod]
    public void StringIsAlphaNumeric_Mixed_ReturnsOk()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlphaNumeric("A1");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void StringIsAlpha_Null_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlpha((string)null);
    }

    [TestMethod]
    public void StringIsAlpha_Empty_ReturnsOk()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlpha(string.Empty);

    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void StringIsAlpha_Whitespace_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlpha("  ");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void StringIsAlpha_Symbol_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlpha("A*");
    }

    [TestMethod]
    public void StringIsAlpha_Letter_ReturnsOk()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlpha("AA");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void StringIsAlpha_Number_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlpha("11");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void StringIsAlpha_Mixed_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlpha("A1");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void StringIsNumeric_Null_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotNumeric((string)null);
    }

    [TestMethod]
    public void StringIsNumeric_Empty_ReturnsOk()
    {
        ArgumentOutOfRangeException.ThrowIfNotNumeric(string.Empty);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void StringIsNumeric_Whitespace_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotNumeric("  ");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void StringIsNumeric_Symbol_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotNumeric("A*");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void StringIsNumeric_Letter_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotNumeric("AA");
    }

    [TestMethod]
    public void StringIsNumeric_Number_ReturnsOk()
    {
        ArgumentOutOfRangeException.ThrowIfNotNumeric("11");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void StringIsNumeric_Mixed_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotNumeric("A1");
    }

    [TestMethod]
    public void StringIsNullOrNumeric_Null_ReturnsOk()
    {
        ArgumentOutOfRangeException.ThrowIfNotNumericOrNull((string)null);
    }

    [TestMethod]
    public void StringIsNullOrNumeric_Empty_ReturnsOk()
    {
        ArgumentOutOfRangeException.ThrowIfNotNumericOrNull(string.Empty);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void StringIsNullOrNumeric_Whitespace_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotNumericOrNull("  ");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void StringIsNullOrNumeric_Symbol_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotNumericOrNull("A*");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void StringIsNullOrNumeric_Letter_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotNumericOrNull("AA");
    }

    [TestMethod]
    public void StringIsNullOrNumeric_Number_ReturnsOk()
    {
        ArgumentOutOfRangeException.ThrowIfNotNumericOrNull("11");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void StringIsNullOrNumeric_Mixed_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotNumericOrNull("A1");
    }

    #endregion

    #region Char parameter

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void CharIsAlphaNumeric_Symbol_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlphaNumeric((char?)null);
    }

    [TestMethod]
    public void CharIsAlphaNumeric_Letter_ReturnsOk()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlphaNumeric('A');
    }

    [TestMethod]
    public void CharIsAlphaNumeric_Number_ReturnsOk()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlphaNumeric('1');
    }

    [TestMethod]
    public void CharIsAlphaNumeric_LowerCase_ReturnsOk()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlphaNumeric('a');
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void CharIsAlpha_Symbol_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlpha('*');
    }

    [TestMethod]
    public void CharIsAlpha_Letter_ReturnsOk()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlpha('A');
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void CharIsAlpha_Number_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlpha('1');
    }

    [TestMethod]
    public void CharIsAlpha_LowerCase_ReturnsOk()
    {
        ArgumentOutOfRangeException.ThrowIfNotAlpha('a');
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void CharIsNumeric_Symbol_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotNumeric('*');
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void CharIsNumeric_Letter_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotNumeric('A');
    }

    [TestMethod]
    public void CharIsNumeric_Number_ReturnsOk()
    {
        ArgumentOutOfRangeException.ThrowIfNotNumeric('1');
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void CharIsNumeric_LowerCase_ThrowsException()
    {
        ArgumentOutOfRangeException.ThrowIfNotNumeric('a');
    }

    #endregion
}
