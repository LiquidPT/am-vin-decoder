// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.UnitTest.Repositories;

[TestClass]
public class FactoryRepositoryTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Lookup_SymbolVinCode_ThrowsException()
    {
        _ = FactoryRepository.Lookup('*');
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Lookup_NumericVinCode_ThrowsException()
    {
        _ = FactoryRepository.Lookup('1');
    }

    [TestMethod]
    [ExpectedException(typeof(KeyNotFoundException))]
    public void Lookup_UnknownLetterVinCode_ThrowsException()
    {
        _ = FactoryRepository.Lookup('X');
    }

    [TestMethod]
    public void Lookup_KnownLetterVinCode_ReturnsValue()
    {
        var result = FactoryRepository.Lookup('A');
        Assert.IsNotNull(result.Text);
    }
}
