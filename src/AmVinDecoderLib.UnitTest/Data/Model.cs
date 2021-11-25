// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.UnitTest.Data;

[TestClass]
public class Model : VerifyBase
{
    private static VerifySettings _settings;

    public Model()
    {
        _settings = new VerifySettings();
        _settings.UseDirectory("snapshots");
    }

    [TestMethod]
    public Task Lookup_A_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('A', null, null);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_B_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('B', null, null);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_C_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('C', null, null);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_D_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('D', null, null);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_E_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('E', null, null);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_E0_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('E', null, '0');
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_E1_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('E', null, '1');
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_F_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('F', null, null);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_G_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('G', null, null);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_H_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('H', null, null);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_J_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('J', null, null);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_J3_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('J', null, '3');
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_K_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('K', null, null);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_L_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('L', null, null);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_LFE_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('L', "FE", null);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_M_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('M', null, null);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_N_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('N', null, null);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_R_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('R', null, null);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_S_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('S', null, null);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_S0_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('S', null, '0');
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_S1_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('S', null, '1');
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_S2_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('S', null, '2');
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_T_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('T', null, null);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_V_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('V', null, null);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_0_ReturnsExpectedValues()
    {
        var result = ModelRepository.Lookup('0', null, null);
        return Verify(result, _settings);
    }
}
