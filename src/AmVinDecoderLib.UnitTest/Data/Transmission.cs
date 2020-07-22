// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Repositories;
using AmVinDecoderLib.VinComponents.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using vin = AmVinDecoderLib.VinComponents;

namespace AmVinDecoderLib.UnitTest.Data
{
    [TestClass]
    public class Transmission
    {
        [TestMethod]
        public void Lookup_A_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('A');
            TestValues(result, "Manual", TransmissionType.Manual, 6, SteeringPosition.RHD);
        }

        [TestMethod]
        public void Lookup_B_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('B');
            TestValues(result, "Manual", TransmissionType.Manual, 6, SteeringPosition.LHD);
        }

        [TestMethod]
        public void Lookup_C_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('C');
            TestValues(result, "Auto", TransmissionType.Automatic, 6, SteeringPosition.RHD);
        }

        [TestMethod]
        public void Lookup_D_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('D');
            TestValues(result, "Auto", TransmissionType.Automatic, 6, SteeringPosition.LHD);
        }

        [TestMethod]
        public void Lookup_E_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('E');
            TestValues(result, "Sportshift", TransmissionType.AutomatedManual, 6, SteeringPosition.RHD);
        }

        [TestMethod]
        public void Lookup_F_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('F');
            TestValues(result, "Sportshift", TransmissionType.AutomatedManual, 6, SteeringPosition.LHD);
        }

        [TestMethod]
        public void Lookup_G_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('G');
            TestValues(result, "Toyota Manual", TransmissionType.Manual, 6, SteeringPosition.RHD);
        }

        [TestMethod]
        public void Lookup_H_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('H');
            TestValues(result, "Toyota Manual", TransmissionType.Manual, 6, SteeringPosition.LHD);
        }

        [TestMethod]
        public void Lookup_JIsNotV12VantageS_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('J', ModelType.V12VantageCoupe);
            TestValues(result, "Sportshift II", TransmissionType.AutomatedManual, 7, SteeringPosition.RHD);
        }

        [TestMethod]
        public void Lookup_JIsV12VantageS_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('J', ModelType.V12VantageSCoupe);
            TestValues(result, "Sportshift III", TransmissionType.AutomatedManual, 7, SteeringPosition.RHD);
        }

        [TestMethod]
        public void Lookup_KIsNotV12VantageS_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('K', ModelType.V12VantageRoadster);
            TestValues(result, "Sportshift II", TransmissionType.AutomatedManual, 7, SteeringPosition.LHD);
        }

        [TestMethod]
        public void Lookup_KIsV12VantageS_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('K', ModelType.V12VantageSRoadster);
            TestValues(result, "Sportshift III", TransmissionType.AutomatedManual, 7, SteeringPosition.LHD);
        }

        [TestMethod]
        public void Lookup_L_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('L');
            TestValues(result, "8-speed Auto", TransmissionType.Automatic, 8, SteeringPosition.RHD);
        }

        [TestMethod]
        public void Lookup_M_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('M');
            TestValues(result, "8-speed Auto", TransmissionType.Automatic, 8, SteeringPosition.LHD);
        }

        [TestMethod]
        public void Lookup_T_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('T');
            TestValues(result, "9-speed Auto", TransmissionType.Automatic, 9, SteeringPosition.RHD);
        }

        [TestMethod]
        public void Lookup_U_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('U');
            TestValues(result, "9-speed Auto", TransmissionType.Automatic, 9, SteeringPosition.LHD);
        }

        private void TestValues(vin.Transmission actual, string expectedText, TransmissionType expectedTransmissionType, int expectedForwardSpeeds, SteeringPosition expectedSteeringPosition)
        {
            Assert.IsNotNull(actual);

            Assert.AreEqual(expectedText, actual.Text);
            Assert.AreEqual(expectedTransmissionType, actual.TransmissionType);
            Assert.AreEqual(expectedForwardSpeeds, actual.ForwardSpeeds);
            Assert.AreEqual(expectedSteeringPosition, actual.SteeringPosition);
        }
    }
}
