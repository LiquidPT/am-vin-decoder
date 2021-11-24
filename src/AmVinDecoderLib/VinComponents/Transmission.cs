// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using AmVinDecoderLib.Properties;
using AmVinDecoderLib.VinComponents.Enums;

namespace AmVinDecoderLib.VinComponents;

public class Transmission : BaseVinComponent
{
    public TransmissionType TransmissionType { get; set; }

    public int ForwardSpeeds { get; set; }

    public SteeringPosition SteeringPosition { get; set; }

    public override string ToString(IFormatProvider provider)
    {
        if (TransmissionType == TransmissionType.Manual)
        {
            return string.Format(provider, Resources.Transmission_ManualFormat, ForwardSpeeds, SteeringPosition);
        }

        if (TransmissionType == TransmissionType.Automatic)
        {
            return string.Format(provider, Resources.Transmission_AutomaticFormat, ForwardSpeeds, SteeringPosition);
        }

        return string.Format(provider, Resources.Transmission_AutomatedManualFormat, Text, ForwardSpeeds, SteeringPosition);
    }
}
