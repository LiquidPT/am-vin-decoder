using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using AmVinDecoderLib.Properties;

namespace AmVinDecoderLib.Utilities;

/// <summary>
/// Provides extension methods for validating string arguments and throwing exceptions when the argument does not meet
/// numeric requirements.
/// </summary>
public static class ArgumentExceptionExtensions
{
    private static readonly CompositeFormat ErrorFormatLengthComposite = CompositeFormat.Parse(Resources.Error_Format_Length);
    private static readonly CompositeFormat ErrorFormatStartsWithComposite = CompositeFormat.Parse(Resources.Error_Format_StartsWith);

    extension(ArgumentException)
    {
        /// <summary>Throws an exception if <paramref name="argument"/> is not the expected length.</summary>
        /// <param name="argument">The string argument to validate.</param>
        /// <param name="length">The required length of the string <paramref name="argument"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="argument"/> corresponds.</param>
        /// <exception cref="ArgumentNullException"><paramref name="argument"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="argument"/> is not the expected length.</exception>
        public static void ThrowIfNotLength([NotNull] string? argument, int length, [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            ArgumentNullException.ThrowIfNull(argument, paramName);
            if (argument.Length == length)
            {
                return;
            }

            throw new ArgumentException(argument, string.Format(CultureInfo.CurrentCulture, ErrorFormatLengthComposite, length, argument.Length));
        }

        /// <summary>Throws an exception if <paramref name="argument"/> is not the expected length.</summary>
        /// <param name="argument">The string argument to validate.</param>
        /// <param name="substring">The required starting substring of the string <paramref name="argument"/>.</param>
        /// <param name="stringComparison">The type of string comparison to use.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="argument"/> corresponds.</param>
        /// <exception cref="ArgumentNullException"><paramref name="argument"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="argument"/> is not the expected length.</exception>
        public static void ThrowIfDoesNotStartWith([NotNull] string? argument, string substring, StringComparison stringComparison, [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            ArgumentNullException.ThrowIfNull(argument, paramName);
            if (argument.StartsWith(substring, stringComparison))
            {
                return;
            }

            throw new ArgumentException(argument, string.Format(CultureInfo.CurrentCulture, ErrorFormatStartsWithComposite, argument, substring));
        }
    }
}
