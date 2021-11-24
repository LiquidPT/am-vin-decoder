// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.UnitTest.VinComponents
{
    [TestClass]
    public class BodyType
    {
        [TestMethod]
        public void ToString_FourSeats_ReturnsExpectedValue()
        {
            var component = new vin.BodyType()
            {
                BodyStyle = BodyStyle.Sedan,
                DoorCount = 5,
                Text = "Test Text",
                SeatingConfiguration = SeatingConfiguration.FourSeats,
                SeatCount = 4,
            };

            Assert.AreEqual($"{component.Text} (4 seats)", component.ToString());
        }

        [TestMethod]
        public void ToString_TwoPlusTwo_ReturnsExpectedValue()
        {
            var component = new vin.BodyType()
            {
                BodyStyle = BodyStyle.Sedan,
                DoorCount = 5,
                Text = "Test Text",
                SeatingConfiguration = SeatingConfiguration.TwoPlusTwo,
                SeatCount = 4,
            };

            Assert.AreEqual($"{component.Text} (2+2)", component.ToString());
        }

        [TestMethod]
        public void ToString_TwoPlusZero_ReturnsExpectedValue()
        {
            var component = new vin.BodyType()
            {
                BodyStyle = BodyStyle.Sedan,
                DoorCount = 5,
                Text = "Test Text",
                SeatingConfiguration = SeatingConfiguration.TwoPlusZero,
                SeatCount = 4,
            };

            Assert.AreEqual($"{component.Text} (2+0)", component.ToString());
        }

        [TestMethod]
        public void ToString_TwoPlusUnknown_ReturnsExpectedValue()
        {
            var component = new vin.BodyType()
            {
                BodyStyle = BodyStyle.Sedan,
                DoorCount = 5,
                Text = "Test Text",
                SeatingConfiguration = SeatingConfiguration.TwoPlusUnknown,
                SeatCount = 4,
            };

            Assert.AreEqual($"{component.Text} (2+0 or 2+2)", component.ToString());
        }

        [TestMethod]
        public void ToString_TwoSeats_ReturnsExpectedValue()
        {
            var component = new vin.BodyType()
            {
                BodyStyle = BodyStyle.Sedan,
                DoorCount = 5,
                Text = "Test Text",
                SeatingConfiguration = SeatingConfiguration.TwoSeats,
                SeatCount = 4,
            };

            Assert.AreEqual($"{component.Text} (2 seats)", component.ToString());
        }
    }
}
