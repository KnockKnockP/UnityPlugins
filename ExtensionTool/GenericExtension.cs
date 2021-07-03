using System;

namespace UnityPlugins.Extension {
    /// <summary>
    /// A class that contains generic extension methods.
    /// </summary>
    public static class GenericExtension {
        /// <summary>
        /// Checks if <paramref name="value"/> is smaller than <paramref name="compare"/>.
        /// </summary>
        /// <param name="value">The first value.</param>
        /// <param name="compare">The second value.</param>
        /// <typeparam name="TCompare">
        /// A type of both values. <br />
        /// It must implement <see cref="IComparable"/>.
        /// </typeparam>
        /// <returns>
        /// Returns true if <paramref name="value"/> is smaller than <paramref name="compare"/>.
        /// Otherwise, false.
        /// </returns>
        public static bool IsSmallerThan<TCompare>(this TCompare value, TCompare compare) where TCompare : IComparable => (value.CompareTo(compare) < 0);

        /// <summary>
        /// Checks if <paramref name="value"/> is greater than <paramref name="compare"/>.
        /// </summary>
        /// <param name="value">The first value.</param>
        /// <param name="compare">The second value.</param>
        /// <typeparam name="T">
        /// A type of both values. <br />
        /// It must implement <see cref="IComparable"/>.
        /// </typeparam>
        /// <returns>
        /// Returns true if <paramref name="value"/> is greater than <paramref name="compare"/>.
        /// Otherwise, false.
        /// </returns>
        public static bool IsGreaterThan<T>(this T value, T compare) where T : IComparable => (value.CompareTo(compare) > 0);
    }
}