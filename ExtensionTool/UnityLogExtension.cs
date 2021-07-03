using System.Runtime.CompilerServices;
using UnityEngine;

namespace UnityPlugins.Extension {
    /// <summary>
    ///     A class that helps you with logging objects in Unity using extension methods.
    /// </summary>
    public static class UnityLogExtension {
        /// <summary>
        ///     This is the equivalent of <see cref="Debug.Log(object)" /> but as an extension method.
        ///     This method is aggressively inlined when compiled in the release mode.
        /// </summary>
        /// <param name="message">An object to log.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void UnityLog(this object message) => Debug.Log(message);

        /// <summary>
        ///     This is the equivalent of <see cref="Debug.LogWarning(object)" /> but as an extension method.
        ///     This method is aggressively inlined when compiled in the release mode.
        /// </summary>
        /// <param name="message">An object to log.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void UnityLogWarning(this object message) => Debug.LogWarning(message);

        /// <summary>
        ///     This is the equivalent of <see cref="Debug.LogError(object)" /> but as an extension method.
        ///     This method is aggressively inlined when compiled in the release mode.
        /// </summary>
        /// <param name="message">An <see cref="object" /> to log.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void UnityLogError(this object message) => Debug.LogError(message);
    }
}