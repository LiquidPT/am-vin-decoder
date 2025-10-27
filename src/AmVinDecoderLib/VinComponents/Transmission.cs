// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Properties;
using System.Text;

namespace AmVinDecoderLib.VinComponents;

/// <summary>
/// Represents the transmission component of a VIN, including details such as transmission type,
/// </summary>
public record Transmission : BaseVinComponent
{
    private static readonly CompositeFormat ManualFormat = CompositeFormat.Parse(Resources.Transmission_ManualFormat);
    private static readonly CompositeFormat AutomaticFormat = CompositeFormat.Parse(Resources.Transmission_AutomaticFormat);
    private static readonly CompositeFormat AutomatedManualFormat = CompositeFormat.Parse(Resources.Transmission_AutomatedManualFormat);

    /// <summary>
    /// Gets the transmission type associated with this instance.
    /// </summary>
    public TransmissionType TransmissionType { get; init; }

    /// <summary>
    /// Gets the number of forward speeds supported by the transmission.
    /// </summary>
    public int ForwardSpeeds { get; init; }

    /// <summary>
    /// Gets the steering position for the vehicle.
    /// </summary>
    public SteeringPosition SteeringPosition { get; init; }

    /// <inheritdoc/>
    public override sealed string ToString(IFormatProvider provider) => TransmissionType switch
    {
        TransmissionType.Manual => string.Format(provider, ManualFormat, ForwardSpeeds, SteeringPosition),
        TransmissionType.Automatic => string.Format(provider, AutomaticFormat, ForwardSpeeds, SteeringPosition),
        _ => string.Format(provider, AutomatedManualFormat, Text, ForwardSpeeds, SteeringPosition)
    };
}
