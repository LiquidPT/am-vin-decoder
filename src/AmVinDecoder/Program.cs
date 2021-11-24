// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.IO;
using AmVinDecoder.Properties;
using AmVinDecoderLib;
using Microsoft.Extensions.Configuration;

[assembly: CLSCompliant(true)]

namespace AmVinDecoder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var unitOptions = GetUnitOptions();

            string vin = null;
            if (args?.Length > 0)
            {
                vin = args[0];
            }

            while (true)
            {
                if (vin == null)
                {
                    Console.WriteLine($"{Resources.Prompt_Vin}{Resources.LabelSeperator}");
                    vin = Console.ReadLine();
                }

                var vehicle = VinDecoder.GetVehicleInfo(vin, unitOptions);
                Console.WriteLine($"{Resources.HorizontalRule}");
                Console.WriteLine($"{Resources.Title}");
                Console.WriteLine($"{Resources.HorizontalRule}");
                Console.WriteLine($"{Resources.Label_Vin}{Resources.LabelSeperator}{vin}");
                Console.WriteLine($"{Resources.Label_SerialNumber}{Resources.LabelSeperator}{vehicle.SerialNumber}");
                Console.WriteLine($"{Resources.Label_Model}{Resources.LabelSeperator}{vehicle.Model}");
                Console.WriteLine($"{Resources.Label_ModelYear}{Resources.LabelSeperator}{vehicle.ModelYear}");
                Console.WriteLine($"{Resources.Label_Factory}{Resources.LabelSeperator}{vehicle.Factory}");
                Console.WriteLine($"{Resources.Label_BodyType}{Resources.LabelSeperator}{vehicle.BodyType}");
                Console.WriteLine($"{Resources.Label_Engine}{Resources.LabelSeperator}{vehicle.Engine}");
                Console.WriteLine($"{Resources.Label_Transmisson}{Resources.LabelSeperator}{vehicle.Transmisson}");
                Console.WriteLine($"{Resources.Label_RestraintSystem}{Resources.LabelSeperator}{vehicle.RestraintSystem}");
                Console.WriteLine($"{Resources.HorizontalRule}");
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