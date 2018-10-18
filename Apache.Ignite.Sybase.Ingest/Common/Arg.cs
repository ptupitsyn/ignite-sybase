using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Apache.Ignite.Sybase.Ingest.Common
{
    public class Arg
    {
        [NotNull]
        public static string NotNullOrWhitespace(string arg, [InvokerParameterName] string argName)
        {
            if (arg == null)
            {
                throw new ArgumentNullException(argName);
            }

            if (string.IsNullOrWhiteSpace(arg))
            {
                throw new ArgumentException($"{argName} can not be empty or whitespace.", argName);
            }

            return arg;
        }

        [NotNull]
        public static T NotNull<T>([NoEnumeration] T arg, [InvokerParameterName] string argName)
            where T : class
        {
            return arg ?? throw new ArgumentNullException(argName);
        }

        [NotNull]
        public static ICollection<T> NotNullOrEmpty<T>(ICollection<T> arg, [InvokerParameterName] string argName)
        {
            NotNull(arg, argName);

            if (arg.Count == 0)
            {
                throw new ArgumentException($"{argName} collection can not be empty.", argName);
            }

            return arg;
        }

        [NotNull]
        public static IReadOnlyCollection<T> NotNullOrEmpty<T>(IReadOnlyCollection<T> arg, [InvokerParameterName] string argName)
        {
            NotNull(arg, argName);

            if (arg.Count == 0)
            {
                throw new ArgumentException($"{argName} collection can not be empty.", argName);
            }

            return arg;
        }

        public static T InRange<T>(T arg, T min, T max, [InvokerParameterName] string argName)
            where T : IComparable
        {
            if (arg.CompareTo(min) < 0)
            {
                throw new ArgumentOutOfRangeException(
                    argName,
                    arg,
                    $"{argName} should be between '{min}' and '{max}'.");
            }

            return arg;
        }

        public static T NotDefault<T>(T arg, [InvokerParameterName] string argName)
            where T : struct
        {
            if (EqualityComparer<T>.Default.Equals(arg, default(T)))
            {
                throw new ArgumentException($"{argName} has default value.", argName);
            }

            return arg;
        }
    }
}
