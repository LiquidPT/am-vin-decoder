// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Globalization;

namespace AmVinDecoderLib.UnitTest.VinComponents;

[TestClass]
public class Model
{
    [TestMethod]
    public void ToString_ValidComponent_ReturnsExpectedValue()
    {
        var component = new vin.Model()
        {
            Text = "Test Text",
            ModelType = ModelType.DbsCoupe,
        };

        Assert.AreEqual(component.Text, component.ToString(CultureInfo.CurrentCulture));
    }
}
