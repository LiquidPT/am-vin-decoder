﻿// -------------------------------------------------------------------------------------------------
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
    public class RestraintSystem
    {
        [TestMethod]
        public void Lookup_A_ReturnsExpectedValues()
        {
            var result = RestraintSystemRepository.Lookup('A', "0");
            TestValues(result, "2+2 seating. Front & side (in seats) airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.) + rear seatbelts (ELR/ALR).");
        }

        [TestMethod]
        public void Lookup_B_ReturnsExpectedValues()
        {
            var result = RestraintSystemRepository.Lookup('B', "0");
            TestValues(result, "2+0 seating. Front & side (in seats) airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.).");
        }

        [TestMethod]
        public void Lookup_E_ReturnsExpectedValues()
        {
            var result = RestraintSystemRepository.Lookup('E', "0");
            TestValues(result, "2+0 seating. Front & side (in seats) airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.).");
        }

        [TestMethod]
        public void Lookup_E2013_ReturnsExpectedValues()
        {
            var result = RestraintSystemRepository.Lookup('E', "2013");
            TestValues(result, "2+0 seating. Front & side (in seats) airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.). +dual pretensioners / dual stage load limiters for the seat belts.");
        }

        [TestMethod]
        public void Lookup_F_ReturnsExpectedValues()
        {
            var result = RestraintSystemRepository.Lookup('F', "0");
            TestValues(result, "2+2 seating. Front & side (in seats) airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.) + rear seatbelts (ELR/ALR).");
        }

        [TestMethod]
        public void Lookup_F2013_ReturnsExpectedValues()
        {
            var result = RestraintSystemRepository.Lookup('F', "2013");
            TestValues(result, "2+2 seating. Front & side (in seats) airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.) + rear seatbelts (ELR/ALR). +dual pretensioners / dual stage load limiters for the seat belts.");
        }

        [TestMethod]
        public void Lookup_G_ReturnsExpectedValues()
        {
            var result = RestraintSystemRepository.Lookup('G', "0");
            TestValues(result, "2+0 seating. Front airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.) (light weight seats).");
        }

        [TestMethod]
        public void Lookup_H_ReturnsExpectedValues()
        {
            var result = RestraintSystemRepository.Lookup('H', "0");
            TestValues(result, "4-seater Front & side (in seats) airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.) + rear seatbelts (ELR/ALR) + side curtain in pass & drvr  + both rear doors, pyro-pretension rear seatbelts.");
        }

        [TestMethod]
        public void Lookup_K_ReturnsExpectedValues()
        {
            var result = RestraintSystemRepository.Lookup('K', "0");
            TestValues(result, "2+0 seating. Front & side (in seats) airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.) + dual  pretensioners/dual stage load limiters + curtain side airbags in the cantrails.");
        }

        [TestMethod]
        public void Lookup_L_ReturnsExpectedValues()
        {
            var result = RestraintSystemRepository.Lookup('L', "0");
            TestValues(result, "2+2 seating. Front & side (in seats) airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.) + rear seatbelts (ELR/ALR) + curtain side  airbags in the cantrails.");
        }

        [TestMethod]
        public void Lookup_M_ReturnsExpectedValues()
        {
            var result = RestraintSystemRepository.Lookup('M', "0");
            TestValues(result, "Unknown Cygnet restraint system");
        }

        [TestMethod]
        public void Lookup_N_ReturnsExpectedValues()
        {
            var result = RestraintSystemRepository.Lookup('N', "0");
            TestValues(result, "2+0 seating. Front & side (in seats) airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.) + dual  pretensioners/dual stage load limiters + curtain side airbags in the doors.");
        }

        [TestMethod]
        public void Lookup_P_ReturnsExpectedValues()
        {
            var result = RestraintSystemRepository.Lookup('P', "0");
            TestValues(result, "2+2 seating. Front & side (in seats) airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.) + rear seatbelts (ELR/ALR) + curtain side  airbags in the doors.");
        }

        [TestMethod]
        public void Lookup_RIsNotDb11Volante_ReturnsExpectedValues()
        {
            var result = RestraintSystemRepository.Lookup('R', "0", ModelType.Db11Coupe);
            TestValues(result, "2+2 Airbags Drv/Pass: Front, knee, side (in  seat & cantrail) Seat belts Drv/Pass: 3point ELR, pyropretensioners (Retractor & Sill), singlestage load limiter within retractor (+ ALR pass) Rear Pass: 3point ALR.");
        }

        [TestMethod]
        public void Lookup_RIsDb11Volante_ReturnsExpectedValues()
        {
            var result = RestraintSystemRepository.Lookup('R', "0", ModelType.Db11Volante);
            TestValues(result, "2+2 Airbags Drv/Pass: Front, knee, side (in  seat & cantrail) Seat belts Drv/Pass: 3point ELR, pyropretensioners (Retractor & Sill), singlestage load limiter within retractor (+ ALR pass) Rear Pass: 3point ALR. +Roll Bars & Cantrail airbag in doors.");
        }

        [TestMethod]
        public void Lookup_S_ReturnsExpectedValues()
        {
            var result = RestraintSystemRepository.Lookup('S', "0");
            TestValues(result, "2+0 Airbags Drv/Pass: Front, knee, side (in  seat & cantrail) Seat belts Drv/Pass: 3point ELR, pyropretensioners (Retractor & Sill), singlestage load limiter  within retractor (+ ALR pass)");
        }

        [TestMethod]
        public void Lookup_V_ReturnsExpectedValues()
        {
            var result = RestraintSystemRepository.Lookup('V', "0");
            TestValues(result, "Unknown DBX restraint system");
        }

        private void TestValues(vin.RestraintSystem actual, string expectedText)
        {
            Assert.IsNotNull(actual);

            Assert.AreEqual(expectedText, actual.Text);
        }
    }
}
