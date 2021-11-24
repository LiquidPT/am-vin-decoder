// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Globalization;

namespace AmVinDecoderLib.VinComponents
{
    public abstract class BaseVinComponent
    {
        public string Text { get; set; }

        public override string ToString()
        {
            return ToString(CultureInfo.CurrentCulture);
        }

        public virtual string ToString(IFormatProvider provider)
        {
            return string.Format(provider, "{0}", Text);
        }
    }
}
