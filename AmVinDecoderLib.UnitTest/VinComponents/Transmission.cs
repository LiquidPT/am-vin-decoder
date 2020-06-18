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
    public class Transmission
    {
        [TestMethod]
        public void ToString_Auto_ReturnsExpectedValue()
        {
            var component = new vin.Transmission()
            {
                ForwardSpeeds = 4,
                TransmissionType = TransmissionType.Automatic,
                Text = "Test Text",
            };

            Assert.AreEqual($"{component.ForwardSpeeds} speed auto", component.ToString());
        }

        [TestMethod]
        public void ToString_Manual_ReturnsExpectedValue()
        {
            var component = new vin.Transmission()
            {
                ForwardSpeeds = 4,
                TransmissionType = TransmissionType.Manual,
                Text = "Test Text",
            };

            Assert.AreEqual($"{component.ForwardSpeeds} speed manual", component.ToString());
        }

        [TestMethod]
        public void ToString_AutomatedManual_ReturnsExpectedValue()
        {
            var component = new vin.Transmission()
            {
                ForwardSpeeds = 4,
                TransmissionType = TransmissionType.AutomatedManual,
                Text = "Test Text",
            };

            Assert.AreEqual($"{component.Text} {component.ForwardSpeeds} speed automated manual", component.ToString());
        }
    }
}
