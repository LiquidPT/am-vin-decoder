// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.Properties;

namespace AmVinDecoderLib.VinComponents;

public class Transmission : BaseVinComponent
{
    public TransmissionType TransmissionType { get; set; }

    public int ForwardSpeeds { get; set; }

    public SteeringPosition SteeringPosition { get; set; }

    public override string ToString(IFormatProvider provider) => TransmissionType switch
    {
        TransmissionType.Manual => string.Format(provider, Resources.Transmission_ManualFormat, ForwardSpeeds, SteeringPosition),
        TransmissionType.Automatic => string.Format(provider, Resources.Transmission_AutomaticFormat, ForwardSpeeds, SteeringPosition),
        _ => string.Format(provider, Resources.Transmission_AutomatedManualFormat, Text, ForwardSpeeds, SteeringPosition)
    };
}
