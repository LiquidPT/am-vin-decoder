// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Globalization;
using System.Text;
using AmVinDecoderLib.Properties;

namespace AmVinDecoderLib.VinComponents;

/// <summary>
/// Represents the body type component of a VIN, including details such as door count, body style,
/// </summary>
public record BodyType : BaseVinComponent
{
    private static readonly CompositeFormat BodyTypeCompositeFormat = CompositeFormat.Parse(Resources.BodyType_Format);

    /// <summary>
    /// Gets the number of doors for the vehicle.
    /// </summary>
    public int DoorCount { get; init; }

    /// <summary>
    /// Gets the body style of the vehicle.
    /// </summary>
    public BodyStyle BodyStyle { get; init; }

    /// <summary>
    /// Gets the seating configuration for the venue or event.
    /// </summary>
    public SeatingConfiguration SeatingConfiguration { get; init; }

    /// <summary>
    /// Gets the number of seats available for the item, or null if the seat count is unspecified.
    /// </summary>
    public int? SeatCount { get; init; }

    /// <inheritdoc/>
    public override sealed string ToString(IFormatProvider provider) =>
        string.Format(
            provider,
            BodyTypeCompositeFormat,
            Text,
            Resources.ResourceManager.GetString($"SeatingConfiguration_{SeatingConfiguration}", CultureInfo.CurrentUICulture)
        );
}
