using System.Collections.Generic;
using UnityEngine;

namespace UnityPlugins {
    /// <summary>
    /// A class that contains input tools.
    /// </summary>
    public static class InputTool {
        /// <summary>
        /// Parses <see cref="int"/> from <see cref="input"/> <see cref="string"/>.
        /// </summary>
        /// <param name="input">A <see cref="string"/> to parse from.</param>
        /// <param name="defaultReturn">A value to return when <paramref name="input"/> is either null or empty.</param>
        /// <returns>
        /// Returns a parsed <see cref="int"/> value. <br />
        /// If <paramref name="input"/> is null or empty, it returns <paramref name="defaultReturn"/>.
        /// </returns>
        public static int ParseInt(string input, int defaultReturn) => ((string.IsNullOrEmpty(input) == false) ? int.Parse(input) : defaultReturn);

        /// <summary>
        /// Parses <see cref="long"/> from <see cref="input"/> <see cref="string"/>.
        /// </summary>
        /// <param name="input">A <see cref="string"/> to parse from.</param>
        /// <param name="defaultReturn">A value to return when <paramref name="input"/> is either null or empty.</param>
        /// <returns>
        /// Returns a parsed <see cref="long"/> value. <br />
        /// If <paramref name="input"/> is null or empty, it returns <paramref name="defaultReturn"/>.
        /// </returns>
        public static long ParseLong(string input, long defaultReturn) => ((string.IsNullOrEmpty(input) == false) ? long.Parse(input) : defaultReturn);

        /// <summary>
        /// Converts a mouse position to a <see cref="RaycastHit"/>.
        /// </summary>
        /// <param name="camera">The <see cref="Camera"/> to shoot the <see cref="Ray"/> from.</param>
        /// <param name="distance">
        /// An optional distance parameter. <br />
        /// The default value is 1000.
        /// </param>
        /// <returns>Returns <see cref="RaycastHit"/>.</returns>
        public static RaycastHit MouseToHit(Camera camera, float distance = 1000f) {
            Ray mouseRay = camera.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(mouseRay,
                            out RaycastHit raycastHit,
                            distance);
            return raycastHit;
        }

        /// <summary>
        /// Converts a mouse position to <see cref="IEnumerable{T}"/> of all <see cref="RaycastHit2D"/>s.
        /// </summary>
        /// <param name="camera">A <see cref="Camera"/> to perform a ray cast. </param>
        /// <returns>Returns <see cref="IEnumerable{T}"/> of all <see cref="RaycastHit2D"/>s.</returns>
        public static IEnumerable<RaycastHit2D> MouseToHits2D(Camera camera) => Physics2D.RaycastAll(camera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
    }
}