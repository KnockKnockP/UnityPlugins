using UnityEngine;

namespace UnityPlugins.Extension {
    /// <summary>
    /// A class that contains <see cref="Vector3Int"/> extension methods.
    /// </summary>
    public static class Vector3IntExtension {
        /// <summary>
        /// Converts <see cref="Vector3Int"/> to <see cref="Vector3"/>.
        /// </summary>
        /// <param name="target">A <see cref="Vector3Int"/> to convert.</param>
        /// <returns>Returns a new <see cref="Vector3"/>.</returns>
        public static Vector3 ToVector3(this Vector3Int target) =>
            new Vector3(target.x,
                        target.y,
                        target.z);
    }
}