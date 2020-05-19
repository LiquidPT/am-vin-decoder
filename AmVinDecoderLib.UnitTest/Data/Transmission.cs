﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Repositories;
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
            TestValues(result, "Manual", 6, expectedHasClutchPedal: true);
        }

        [TestMethod]
        public void Lookup_B_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('B');
            TestValues(result, "Manual", 6, expectedHasClutchPedal: true);
        }

        [TestMethod]
        public void Lookup_C_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('C');
            TestValues(result, "Auto", 6, expectedHasTorqueConverter: true);
        }

        [TestMethod]
        public void Lookup_D_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('D');
            TestValues(result, "Auto", 6, expectedHasTorqueConverter: true);
        }

        [TestMethod]
        public void Lookup_E_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('E');
            TestValues(result, "Sportshift", 6);
        }

        [TestMethod]
        public void Lookup_F_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('F');
            TestValues(result, "Sportshift", 6);
        }

        [TestMethod]
        public void Lookup_JF_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('J', false);
            TestValues(result, "Sportshift II", 7);
        }

        [TestMethod]
        public void Lookup_KF_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('K', false);
            TestValues(result, "Sportshift II", 7);
        }

        [TestMethod]
        public void Lookup_JT_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('J', true);
            TestValues(result, "Sportshift III", 7);
        }

        [TestMethod]
        public void Lookup_KT_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('K', true);
            TestValues(result, "Sportshift III", 7);
        }

        [TestMethod]
        public void Lookup_L_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('L');
            TestValues(result, "8-speed Auto", 8, expectedHasTorqueConverter: true);
        }

        [TestMethod]
        public void Lookup_M_ReturnsExpectedValues()
        {
            var result = TransmissionRepository.Lookup('M');
            TestValues(result, "8-speed Auto", 8, expectedHasTorqueConverter: true);
        }

        private void TestValues(vin.Transmission actual, string expectedText, int expectedForwardSpeeds, bool expectedHasClutchPedal = false, bool expectedHasTorqueConverter = false)
        {
            Assert.IsNotNull(actual);

            Assert.AreEqual(expectedText, actual.Text);
            Assert.AreEqual(expectedForwardSpeeds, actual.ForwardSpeeds);
            Assert.AreEqual(expectedHasClutchPedal, actual.HasClutchPedal);
            Assert.AreEqual(expectedHasTorqueConverter, actual.HasTorqueConverter);
        }
    }
}
