using UnityEngine;

namespace UnityPlugins.Extension {
    /// <summary>
    ///     A class that contains <see cref="Vector2Int" /> extension methods.
    /// </summary>
    public static class Vector2IntExtension {
        /// <summary>
        ///     Converts <see cref="Vector2Int" /> to <see cref="Vector2" />.
        /// </summary>
        /// <param name="target">A <see cref="Vector2Int" /> to convert.</param>
        /// <returns>Returns a new <see cref="Vector2" />.</returns>
        public static Vector2 ToVector2(this Vector2Int target) => new Vector2(target.x, target.y);
    }
}