using UnityEngine;

namespace UnityPlugins.Extension {
    /// <summary>
    /// A class that contains <see cref="Vector2"/> extension methods.
    /// </summary>
    public static class Vector2Extension {
        /// <summary>
        /// An array that contains 4 different directions in a counter-clockwise (up, left, down, right) order.
        /// </summary>
        public static readonly Vector2[] Directions = {
            Vector2.up,
            Vector2.left,
            Vector2.down,
            Vector2.right
        };

        /// <summary>
        /// Converts a <see cref="Vector2"/> to <see cref="Vector2Int"/>. <br />
        /// All values are casted into <see cref="int"/>.
        /// </summary>
        /// <param name="target">A <see cref="Vector2"/> value to convert.</param>
        /// <returns>Returns a new <see cref="Vector2Int"/>.</returns>
        public static Vector2Int ToVector2Int(this Vector2 target) => new Vector2Int((int)(target.x), (int)(target.y));
    }
}