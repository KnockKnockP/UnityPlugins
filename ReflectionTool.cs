using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityPlugins {
    /// <summary>
    /// A class that helps with reflections.
    /// </summary>
    public static class ReflectionTool {
        /// <summary>
        /// Retrieves all values that is defined in <typeparamref name="TEnum"/>.
        /// </summary>
        /// <typeparam name="TEnum">A type of an enum.</typeparam>
        /// <returns>An array of a specified enum's values.</returns>
        public static TEnum[] GetEnumValues<TEnum>() where TEnum : Enum => (TEnum[])(Enum.GetValues(typeof(TEnum)));

        /// <summary>
        /// Finds all classes implementing <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">An inheritable class.</typeparam>
        /// <returns>An <see cref="IEnumerable{T}"/> of all types implementing <typeparamref name="T"/>.</returns>
        public static IEnumerable<Type> FindAllClassesImplementing<T>() =>
            AppDomain.CurrentDomain.GetAssemblies()
                     .SelectMany(s => s.GetTypes())
                     .Where(p => (p != typeof(T)) && (typeof(T).IsAssignableFrom(p)));
    }
}