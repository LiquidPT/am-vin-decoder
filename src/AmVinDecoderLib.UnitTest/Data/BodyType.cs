// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.UnitTest.Data;

[TestClass]
public class BodyType : VerifyBase
{
    private static VerifySettings _settings;

    public BodyType()
    {
        _settings = new VerifySettings();
        _settings.UseDirectory("snapshots");
    }

    [TestMethod]
    public Task Lookup_01_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("01");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_03_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("03");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_02_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("02");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_04_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("04");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_05_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("05");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_AA_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("AA");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_AC_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("AC");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_AB_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("AB");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_AD_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("AD");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_AE_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("AE");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_AG_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("AG");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_AF_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("AF");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_AH_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("AH");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_BA_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("BA");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_BB_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("BB");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_BC_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("BC");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_BD_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("BD");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_BE_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("BE");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_BF_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("BF");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_BN_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("BN");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_BP_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("BP");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_CA_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("CA");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_CB_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("CB");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_CC_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("CC");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_CE_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("CE");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_CF_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("CF");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_CG_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("CG");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_CH_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("CH");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_CJ_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("CJ");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_CK_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("CK");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_CL_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("CL");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_CM_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("CM");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_CP_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("CP");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_CR_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("CR");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_CU_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("CU");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_DA_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("DA");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_DE_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("DE");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_DF_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("DF");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_EA_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("EA");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_EC_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("EC");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_EB_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("EB");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_ED_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("ED");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_FA_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("FA");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_FC_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("FC");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_FE_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("FE");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_GA_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("GA");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_HA_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("HA");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_HC_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("HC");
        return Verify(result, _settings);
    }

    [TestMethod]
    public Task Lookup_JA_ReturnsExpectedValues()
    {
        var result = BodyTypeRepository.Lookup("JA");
        return Verify(result, _settings);
    }
}
