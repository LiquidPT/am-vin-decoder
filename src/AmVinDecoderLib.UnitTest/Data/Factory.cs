// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.UnitTest.Data;

[TestClass]
public class Factory : VerifyBase
{
    private static VerifySettings _settings;

    public Factory()
    {
        _settings = new VerifySettings();
        _settings.UseDirectory("snapshots");
    }

    [TestMethod]
    public Task Lookup_A_ReturnsExpectedValues()
    {
        var result = FactoryRepository.Lookup('A');
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_G_ReturnsExpectedValues()
    {
        var result = FactoryRepository.Lookup('G');
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_J_ReturnsExpectedValues()
    {
        var result = FactoryRepository.Lookup('J');
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_T_ReturnsExpectedValues()
    {
        var result = FactoryRepository.Lookup('T');
        return Verify(result, _settings);
    }
}
