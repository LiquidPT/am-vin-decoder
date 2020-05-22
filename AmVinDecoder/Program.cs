// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.IO;
using AmVinDecoderLib;
using Microsoft.Extensions.Configuration;

namespace AmVinDecoder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var unitOptions = GetUnitOptions();

            string vin = null;
            if (args.Length > 0)
            {
                vin = args[0];
            }

            while (true)
            {
                if (vin == null)
                {
                    Console.WriteLine("VIN?: ");
                    vin = Console.ReadLine();
                }

                var vehicle = VinDecoder.GetVehicleInfo(vin, unitOptions);
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("Aston Martin VIN Decoder");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine($"VIN: {vin}");
                Console.WriteLine($"SerialNumber: {vehicle.SerialNumber}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Model Year: {vehicle.ModelYear}");
                Console.WriteLine($"Factory: {vehicle.Factory}");
                Console.WriteLine($"Body Type: {vehicle.BodyType}");
                Console.WriteLine($"Seating: {vehicle.Seating}");
                Console.WriteLine($"Engine: {vehicle.Engine}");
                Console.WriteLine($"Transmisson: {vehicle.Transmisson}");
                Console.WriteLine($"Steering Position: {vehicle.SteeringPosition}");
                Console.WriteLine($"Restraint System: {vehicle.RestraintSystem}");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine();

                vin = null;
            }
        }

        private static UnitOptions GetUnitOptions()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = builder.Build();
            return config.GetSection("Units").Get<UnitOptions>();
        }
    }
}