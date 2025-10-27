// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Globalization;

namespace AmVinDecoderLib.VinComponents;

/// <summary>
/// Represents the base class for VIN components, providing common functionality and properties.
/// </summary>
public abstract record BaseVinComponent
{
    /// <summary>
    /// Gets the text content associated with this instance.
    /// </summary>
    public string Text { get; init; }

    /// <summary>
    /// Returns a string representation of the current object using the current culture formatting conventions.
    /// </summary>
    /// <remarks>This method uses <see cref="CultureInfo.CurrentCulture"/> to format the string output. For
    /// culture-specific formatting, use the overload that accepts a <see cref="CultureInfo"/> parameter.</remarks>
    /// <returns>A string that represents the current object, formatted according to the current culture.</returns>
    public override sealed string ToString() => ToString(CultureInfo.CurrentCulture);

    /// <summary>
    /// Returns a string representation of the current object, formatted using the specified format provider.
    /// </summary>
    /// <param name="provider">An object that supplies culture-specific formatting information for the returned string.</param>
    /// <returns>A string that represents the current object, formatted according to the specified format provider.</returns>
    public virtual string ToString(IFormatProvider provider) => string.Format(provider, "{0}", Text);
}
