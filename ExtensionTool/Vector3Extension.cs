using UnityEngine;

namespace UnityPlugins.Extension {
    /// <summary>
    /// A class that contains <see cref="Vector3"/> extension methods.
    /// </summary>
    public static class Vector3Extension {
        /// <summary>
        /// Converts <see cref="Vector3"/> to <see cref="Vector3Int"/>. <br />
        /// All values are casted into <see cref="int"/>.
        /// </summary>
        /// <param name="target">A <see cref="Vector3"/> to convert.</param>
        /// <returns>Returns a new <see cref="Vector3Int"/>.</returns>
        public static Vector3Int ToVector3Int(this Vector3 target) =>
            new Vector3Int((int)(target.x),
                           (int)(target.y),
                           (int)(target.z));

        /// <summary>
        /// Converts <see cref="Vector3"/> to <see cref="Vector2Int"/>. <br />
        /// All values are casted into <see cref="int"/>.
        /// </summary>
        /// <param name="target">A <see cref="Vector3"/> to convert.</param>
        /// <returns>Returns a new <see cref="Vector2Int"/>.</returns>
        public static Vector2Int ToVector2Int(this Vector3 target) => new Vector2Int((int)(target.x), (int)(target.y));
    }
}