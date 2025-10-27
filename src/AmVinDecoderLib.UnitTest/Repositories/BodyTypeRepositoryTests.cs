// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.UnitTest.Repositories;

[TestClass]
public class BodyTypeRepositoryTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Lookup_NullVinCode_ThrowsException()
    {
        _ = new BodyTypeRepository().Lookup(null!);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Lookup_EmptyVinCode_ThrowsException()
    {
        _ = new BodyTypeRepository().Lookup(string.Empty);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Lookup_WhitespaceVinCode_ThrowsException()
    {
        _ = new BodyTypeRepository().Lookup("  ");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Lookup_OneCharacterVinCode_ThrowsException()
    {
        _ = new BodyTypeRepository().Lookup("A");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Lookup_ThreeCharacterVinCode_ThrowsException()
    {
        _ = new BodyTypeRepository().Lookup("AAA");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Lookup_SymbolInVinCode_ThrowsException()
    {
        _ = new BodyTypeRepository().Lookup("*A");
    }

    [TestMethod]
    [ExpectedException(typeof(KeyNotFoundException))]
    public void Lookup_UnkonwnNumericVinCode_ThrowsException()
    {
        _ = new BodyTypeRepository().Lookup("00");
    }

    [TestMethod]
    [ExpectedException(typeof(KeyNotFoundException))]
    public void Lookup_UnknownLetterVinCode_ThrowsException()
    {
        _ = new BodyTypeRepository().Lookup("XX");
    }

    [TestMethod]
    public void Lookup_KnownNumericVinCode_ReturnsValue()
    {
        var result = new BodyTypeRepository().Lookup("01");
        Assert.IsNotNull(result.Text);
    }

    [TestMethod]
    public void Lookup_KnownLetterVinCode_ReturnsValue()
    {
        var result = new BodyTypeRepository().Lookup("AA");
        Assert.IsNotNull(result.Text);
    }
}
