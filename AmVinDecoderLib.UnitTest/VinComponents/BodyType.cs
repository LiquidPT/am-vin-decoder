﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.VinComponents.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using vin = AmVinDecoderLib.VinComponents;

namespace AmVinDecoderLib.UnitTest.VinComponents
{
    [TestClass]
    public class BodyType
    {
        [TestMethod]
        public void ToString_ValidComponent_ReturnsExpectedValue()
        {
            var component = new vin.BodyType()
            {
                BodyStyle = BodyStyle.Sedan,
                DoorCount = 5,
                Text = "Test Text",
            };

            Assert.AreEqual(component.Text, component.ToString());
        }
    }
}
