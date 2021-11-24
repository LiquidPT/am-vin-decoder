// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.UnitTest.Data;

[TestClass]
public class Engine : VerifyBase
{
    private readonly PowerUnit powerUnit = PowerUnit.Kw;
    private readonly TorqueUnit torqueUnit = TorqueUnit.Nm;

    private static VerifySettings _settings;

    public Engine()
    {
        _settings = new VerifySettings();
        _settings.UseDirectory("snapshots");
    }

    [TestMethod]
    public Task Lookup_A_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('A', powerUnit, torqueUnit);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_B_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('B', powerUnit, torqueUnit);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_C_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('C', powerUnit, torqueUnit);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_D_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('D', powerUnit, torqueUnit);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_E_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('E', powerUnit, torqueUnit);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_F_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('F', powerUnit, torqueUnit);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_G_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('G', powerUnit, torqueUnit);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_J_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('J', powerUnit, torqueUnit);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_K_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('K', powerUnit, torqueUnit);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_L_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('L', powerUnit, torqueUnit);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_M_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('M', powerUnit, torqueUnit);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_N_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('N', powerUnit, torqueUnit);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_P_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('P', powerUnit, torqueUnit);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_U_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('U', powerUnit, torqueUnit);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_R_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('R', powerUnit, torqueUnit);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_T_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('T', powerUnit, torqueUnit);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_S_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('S', powerUnit, torqueUnit);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_V_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('V', powerUnit, torqueUnit);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_VIsNewDbsCoupe_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('V', powerUnit, torqueUnit, ModelType.NewDbsCoupe);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_VIsDb11Amr_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('V', PowerUnit.Bhp, TorqueUnit.LbFt, ModelType.Db11Amr);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_W_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('W', powerUnit, torqueUnit);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_WIsDb11Coupe_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('W', PowerUnit.Bhp, TorqueUnit.LbFt, ModelType.Db11Coupe);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_WIsDb11Volante_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('W', PowerUnit.Bhp, TorqueUnit.LbFt, ModelType.Db11Volante);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_WIsDbx_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('W', PowerUnit.Bhp, TorqueUnit.LbFt, ModelType.Dbx);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_Z_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('Z', powerUnit, torqueUnit);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_0_ReturnsExpectedValues()
    {
        var result = EngineRepository.Lookup('0', powerUnit, torqueUnit);
        return Verify(result, _settings);
    }
}
