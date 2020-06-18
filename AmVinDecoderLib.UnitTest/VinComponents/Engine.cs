// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.VinComponents.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using vin = AmVinDecoderLib.VinComponents;

namespace AmVinDecoderLib.UnitTest.VinComponents
{
    [TestClass]
    public class Engine
    {
        [TestMethod]
        public void ToString_ValidComponent_ReturnsExpectedValue()
        {
            var component = new vin.Engine()
            {
                Code = "A",
                Cylinders = 2,
                DisplacementInCc = 1000,
                Induction = Induction.TurboCharged,
                MaxPower = 200,
                MaxPowerRpm = 8000,
                MaxPowerUnit = PowerUnit.Bhp,
                MaxTorque = 150,
                MaxTorqueRpm = 4500,
                MaxTorqueUnit = TorqueUnit.LbFt,
                Text = "Test Text",
            };

            Assert.AreEqual(component.Text, component.ToString());
        }
    }
}
