using System;
using System.Collections.Generic;
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
public static class ArgumentOutOfRangeExceptionExtensions
{
    extension(ArgumentOutOfRangeException)
    {
        /// <summary>Throws an exception if <paramref name="argument"/> is non-numeric or null.</summary>
        /// <param name="argument">The string argument to validate.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="argument"/> corresponds.</param>
        /// <exception cref="ArgumentNullException"><paramref name="argument"/> is null.</exception>
        public static void ThrowIfNotNumeric([NotNull] string? argument, [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            ArgumentNullException.ThrowIfNull(argument, paramName);
            if (argument.All(char.IsDigit))
            {
                return;
            }

            throw new ArgumentOutOfRangeException(argument, Resources.Error_OnlyDigits);
        }

        /// <summary>Throws an exception if <paramref name="argument"/> is non-alphabetic or null.</summary>
        /// <param name="argument">The string argument to validate.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="argument"/> corresponds.</param>
        /// <exception cref="ArgumentNullException"><paramref name="argument"/> is null.</exception>
        public static void ThrowIfNotAlpha([NotNull] string? argument, [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            ArgumentNullException.ThrowIfNull(argument, paramName);
            if (argument.All(char.IsLetter))
            {
                return;
            }

            throw new ArgumentOutOfRangeException(argument, Resources.Error_OnlyLetters);
        }

        /// <summary>Throws an exception if <paramref name="argument"/> is non-alphanumeric or null.</summary>
        /// <param name="argument">The string argument to validate.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="argument"/> corresponds.</param>
        /// <exception cref="ArgumentNullException"><paramref name="argument"/> is null.</exception>
        public static void ThrowIfNotAlphaNumeric([NotNull] string? argument, [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            ArgumentNullException.ThrowIfNull(argument, paramName);
            if (argument.All(char.IsLetterOrDigit))
            {
                return;
            }

            throw new ArgumentOutOfRangeException(argument, Resources.Error_OnlyLettersAndDigits);
        }

        /// <summary>Throws an exception if <paramref name="argument"/> is non-numeric.</summary>
        /// <param name="argument">The string argument to validate.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="argument"/> corresponds.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="argument"/> contains any non-numeric characters.</exception>
        public static void ThrowIfNotNumericOrNull(string? argument, [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            if (string.IsNullOrEmpty(argument))
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(argument))
            {
                throw new ArgumentOutOfRangeException(argument, Resources.Error_OnlyDigits);
            }

            if (argument.All(char.IsDigit))
            {
                return;
            }

            throw new ArgumentOutOfRangeException(argument, Resources.Error_OnlyDigits);
        }

        /// <summary>Throws an exception if <paramref name="argument"/> is non-numeric, null, empty, or consists only of white-space characters.</summary>
        /// <param name="argument">The string argument to validate.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="argument"/> corresponds.</param>
        /// <exception cref="ArgumentNullException"><paramref name="argument"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="argument"/> is empty or consists only of white-space characters.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="argument"/> contains any non-numeric characters.</exception>
        public static void ThrowIfNotNumeric([NotNull] char? argument, [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            if (!argument.HasValue)
            {
                throw new ArgumentNullException(nameof(argument));
            }

            if (char.IsDigit(argument.Value))
            {
                return;
            }

            throw new ArgumentOutOfRangeException(paramName, Resources.Error_CharDigit);
        }

        /// <summary>Throws an exception if <paramref name="argument"/> is non-alphabetic, null, empty, or consists only of white-space characters.</summary>
        /// <param name="argument">The string argument to validate.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="argument"/> corresponds.</param>
        /// <exception cref="ArgumentNullException"><paramref name="argument"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="argument"/> is empty or consists only of white-space characters.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="argument"/> contains any non-alphabetic characters.</exception>
        public static void ThrowIfNotAlpha([NotNull] char? argument, [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            if (!argument.HasValue)
            {
                throw new ArgumentNullException(nameof(argument));
            }

            if (char.IsLetter(argument.Value))
            {
                return;
            }

            throw new ArgumentOutOfRangeException(paramName, Resources.Error_CharLetter);
        }

        /// <summary>Throws an exception if <paramref name="argument"/> is non-alphanumeric, null, empty, or consists only of white-space characters.</summary>
        /// <param name="argument">The string argument to validate.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="argument"/> corresponds.</param>
        /// <exception cref="ArgumentNullException"><paramref name="argument"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="argument"/> is empty or consists only of white-space characters.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="argument"/> contains any non-alphanumeric characters.</exception>
        public static void ThrowIfNotAlphaNumeric([NotNull] char? argument, [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            if (!argument.HasValue)
            {
                throw new ArgumentNullException(nameof(argument));
            }

            if (char.IsLetterOrDigit(argument.Value))
            {
                return;
            }

            throw new ArgumentOutOfRangeException(paramName, Resources.Error_OnlyLettersAndDigits);
        }

        /// <summary>Throws an exception if <paramref name="argument"/> is non-numeric.</summary>
        /// <param name="argument">The string argument to validate.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="argument"/> corresponds.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="argument"/> contains any non-numeric characters.</exception>
        public static void ThrowIfNotNumericOrNull(char? argument, [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            if (!argument.HasValue)
            {
                return;
            }

            if (char.IsDigit(argument.Value))
            {
                return;
            }

            throw new ArgumentOutOfRangeException(paramName, Resources.Error_CharDigit);
        }

    }
}
