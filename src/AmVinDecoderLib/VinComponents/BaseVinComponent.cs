// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Globalization;

namespace AmVinDecoderLib.VinComponents;

public abstract record BaseVinComponent
{
    public string Text { get; init; }

    public override sealed string ToString() => ToString(CultureInfo.CurrentUICulture);

    public virtual string ToString(IFormatProvider provider) => string.Format(provider, "{0}", Text);
}
