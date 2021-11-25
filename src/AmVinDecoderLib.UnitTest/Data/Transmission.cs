// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.UnitTest.Data;

[TestClass]
public class Transmission : VerifyBase
{
    private static VerifySettings _settings;

    public Transmission()
    {
        _settings = new VerifySettings();
        _settings.UseDirectory("snapshots");
    }

    [TestMethod]
    public Task Lookup_A_ReturnsExpectedValues()
    {
        var result = TransmissionRepository.Lookup('A');
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_B_ReturnsExpectedValues()
    {
        var result = TransmissionRepository.Lookup('B');
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_C_ReturnsExpectedValues()
    {
        var result = TransmissionRepository.Lookup('C');
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_D_ReturnsExpectedValues()
    {
        var result = TransmissionRepository.Lookup('D');
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_E_ReturnsExpectedValues()
    {
        var result = TransmissionRepository.Lookup('E');
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_F_ReturnsExpectedValues()
    {
        var result = TransmissionRepository.Lookup('F');
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_G_ReturnsExpectedValues()
    {
        var result = TransmissionRepository.Lookup('G');
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_H_ReturnsExpectedValues()
    {
        var result = TransmissionRepository.Lookup('H');
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_JIsNotV12VantageS_ReturnsExpectedValues()
    {
        var result = TransmissionRepository.Lookup('J', ModelType.V12VantageCoupe);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_JIsV12VantageS_ReturnsExpectedValues()
    {
        var result = TransmissionRepository.Lookup('J', ModelType.V12VantageSCoupe);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_KIsNotV12VantageS_ReturnsExpectedValues()
    {
        var result = TransmissionRepository.Lookup('K', ModelType.V12VantageRoadster);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_KIsV12VantageS_ReturnsExpectedValues()
    {
        var result = TransmissionRepository.Lookup('K', ModelType.V12VantageSRoadster);
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_L_ReturnsExpectedValues()
    {
        var result = TransmissionRepository.Lookup('L');
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_M_ReturnsExpectedValues()
    {
        var result = TransmissionRepository.Lookup('M');
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_T_ReturnsExpectedValues()
    {
        var result = TransmissionRepository.Lookup('T');
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_U_ReturnsExpectedValues()
    {
        var result = TransmissionRepository.Lookup('U');
        return Verify(result, _settings);
    }
}
