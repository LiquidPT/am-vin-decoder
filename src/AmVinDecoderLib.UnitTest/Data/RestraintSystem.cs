// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.UnitTest.Data;

[TestClass]
public class RestraintSystem : VerifyBase
{
    private static VerifySettings _settings;

    public RestraintSystem()
    {
        _settings = new VerifySettings();
        _settings.UseDirectory("snapshots");
    }

    [TestMethod]
    public Task Lookup_A_ReturnsExpectedValues()
    {
        var result = new RestraintSystemRepository().Lookup('A', "0");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_B_ReturnsExpectedValues()
    {
        var result = new RestraintSystemRepository().Lookup('B', "0");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_E_ReturnsExpectedValues()
    {
        var result = new RestraintSystemRepository().Lookup('E', "0");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_E2013_ReturnsExpectedValues()
    {
        var result = new RestraintSystemRepository().Lookup('E', "2013");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_F_ReturnsExpectedValues()
    {
        var result = new RestraintSystemRepository().Lookup('F', "0");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_F2013_ReturnsExpectedValues()
    {
        var result = new RestraintSystemRepository().Lookup('F', "2013");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_G_ReturnsExpectedValues()
    {
        var result = new RestraintSystemRepository().Lookup('G', "0");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_H_ReturnsExpectedValues()
    {
        var result = new RestraintSystemRepository().Lookup('H', "0");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_K_ReturnsExpectedValues()
    {
        var result = new RestraintSystemRepository().Lookup('K', "0");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_L_ReturnsExpectedValues()
    {
        var result = new RestraintSystemRepository().Lookup('L', "0");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_M_ReturnsExpectedValues()
    {
        var result = new RestraintSystemRepository().Lookup('M', "0");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_N_ReturnsExpectedValues()
    {
        var result = new RestraintSystemRepository().Lookup('N', "0");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_P_ReturnsExpectedValues()
    {
        var result = new RestraintSystemRepository().Lookup('P', "0");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_RIsNotDb11Volante_ReturnsExpectedValues()
    {
        var result = new RestraintSystemRepository().Lookup('R', "0", ModelType.Db11Coupe);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_RIsDb11Volante_ReturnsExpectedValues()
    {
        var result = new RestraintSystemRepository().Lookup('R', "0", ModelType.Db11Volante);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_S_ReturnsExpectedValues()
    {
        var result = new RestraintSystemRepository().Lookup('S', "0");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_V_ReturnsExpectedValues()
    {
        var result = new RestraintSystemRepository().Lookup('V', "0");
        return Verify(result, _settings);
    }
}
