// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.Globalization;
using AmVinDecoderLib.Properties;
using AmVinDecoderLib.VinComponents.Enums;

namespace AmVinDecoderLib.VinComponents;

public class BodyType : BaseVinComponent
{
    public int DoorCount { get; set; }

    public BodyStyle BodyStyle { get; set; }

    public SeatingConfiguration SeatingConfiguration { get; set; }

    public int? SeatCount { get; set; }

    public override string ToString(IFormatProvider provider)
    {
        return string.Format(provider, Resources.BodyType_Format, Text, Resources.ResourceManager.GetString($"SeatingConfiguration_{SeatingConfiguration}", CultureInfo.CurrentUICulture));
    }
}
