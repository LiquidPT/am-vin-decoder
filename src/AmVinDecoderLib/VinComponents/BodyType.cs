// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Globalization;
using AmVinDecoderLib.Properties;

namespace AmVinDecoderLib.VinComponents;

public record BodyType : BaseVinComponent
{
    public int DoorCount { get; init; }

    public BodyStyle BodyStyle { get; init; }

    public SeatingConfiguration SeatingConfiguration { get; init; }

    public int? SeatCount { get; init; }

    public override sealed string ToString(IFormatProvider provider) => string.Format(provider, Resources.BodyType_Format, Text, Resources.ResourceManager.GetString($"SeatingConfiguration_{SeatingConfiguration}", CultureInfo.CurrentUICulture));
}
