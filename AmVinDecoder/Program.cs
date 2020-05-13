﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using AmVinDecoderLib;

namespace AmVinDecoder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string vin;

            if (args.Length == 0)
            {
                Console.WriteLine("VIN?: ");
                vin = Console.ReadLine();
            }
            else
            {
                vin = args[0];
            }

            var vehicle = VinDecoder.GetVehicleInfo(vin);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Aston Martin VIN Decoder");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"VIN: {vin}");
            Console.WriteLine($"SerialNumber: {vehicle.SerialNumber}");
            Console.WriteLine($"Model: {vehicle.Model.Text}");
            Console.WriteLine($"Model Year: {vehicle.ModelYear.Text}");
            Console.WriteLine($"Factory: {vehicle.Factory.Text}");
            Console.WriteLine($"Body Type: {vehicle.BodyType.Text}");
            Console.WriteLine($"Seating: {vehicle.Seating.Text}");
            Console.WriteLine($"Engine: {vehicle.Engine.Text}");
            Console.WriteLine($"Transmisson: {vehicle.Transmisson.Text}");
            Console.WriteLine($"Steering Position: {vehicle.SteeringPosition.Text}");
            Console.WriteLine($"Restraint System: {vehicle.RestraintSystem.Text}");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}