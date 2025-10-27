// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.Utilities;

/// <summary>
/// Provides utility methods for validating and normalizing Vehicle Identification Number (VIN) codes, ensuring that
/// input characters and strings conform to VIN formatting requirements.
/// </summary>
/// <remarks>This static class offers methods to validate individual VIN code characters and complete VIN code
/// strings, enforcing constraints such as alphanumeric content and required length. All returned VIN codes are
/// normalized to uppercase using the invariant culture. Methods throw exceptions for invalid input, except where
/// explicitly allowed (e.g., when null values are permitted). These utilities are intended to support consistent VIN
/// code handling in applications that process vehicle data.</remarks>
public static class LookupUtility
{
    /// <summary>
    /// Validates that the provided VIN code character is a letter and returns it as an uppercase string.
    /// </summary>
    /// <param name="vinCode"></param>
    /// <returns></returns>
    public static string ValidateLetterVinCode(char vinCode)
    {
        ArgumentOutOfRangeException.ThrowIfNotAlpha(vinCode);

        return vinCode.ToString().ToUpperInvariant();
    }

    /// <summary>
    /// Validates that the specified character is an alphanumeric VIN code and returns its uppercase string
    /// representation.
    /// </summary>
    /// <param name="vinCode">The character to validate and convert. Must be a letter or digit; otherwise, an exception is thrown.</param>
    /// <returns>A string containing the uppercase representation of the validated VIN code character.</returns>
    public static string ValidateLetterOrDigitVinCode(char vinCode)
    {
        ArgumentOutOfRangeException.ThrowIfNotAlphaNumeric(vinCode);

        return vinCode.ToString().ToUpperInvariant();
    }

    /// <summary>
    /// Validates that the specified VIN code consists only of letters or digits and matches the required length.
    /// </summary>
    /// <param name="vinCode">The VIN code to validate. Must be a non-empty, non-whitespace string containing only alphanumeric characters.</param>
    /// <param name="length">The required length of the VIN code. Must match the length of <paramref name="vinCode"/>.</param>
    /// <returns>A string containing the validated VIN code, converted to uppercase using the invariant culture.</returns>
    public static string ValidateLetterOrDigitVinCode(string vinCode, int length)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(vinCode);
        ArgumentException.ThrowIfNotLength(vinCode, length);
        ArgumentOutOfRangeException.ThrowIfNotAlphaNumeric(vinCode);

        return vinCode.ToUpperInvariant();
    }

    /// <summary>
    /// Validates that the specified VIN code consists only of letters or digits and matches the required length,
    /// optionally allowing null values.
    /// </summary>
    /// <param name="vinCode">The VIN code to validate. May be null if <paramref name="allowNull"/> is <see langword="true"/>.</param>
    /// <param name="length">The required length of the VIN code. Must be a positive integer.</param>
    /// <param name="allowNull">Indicates whether a null VIN code is considered valid. If <see langword="true"/>, a null value will be accepted
    /// and no validation will be performed.</param>
    /// <returns>A validated VIN code if the input meets the criteria; otherwise, <see langword="null"/>.</returns>
    public static string? ValidateLetterOrDigitVinCode(string? vinCode, int length, bool allowNull)
    {
        if (allowNull && vinCode is null)
        {
            return null;
        }

        return ValidateLetterOrDigitVinCode(vinCode!, length);
    }
}
