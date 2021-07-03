using System;

namespace UnityPlugins.MultidimensionalArray {
    /// <summary>
    ///     A serializable two dimensional array. <br />
    ///     <example>
    ///         <code>
    ///             [SerializeField] private TwoDimensionalArray&lt;int&gt;[] integer2DArray = new TwoDimensionalArray&lt;int&gt;[5];
    ///         </code>
    ///     </example>
    /// </summary>
    /// <typeparam name="T">A type of an array.</typeparam>
    [Serializable]
    public class TwoDimensionalArray<T> {
        /// <summary>
        ///     An array.
        /// </summary>
        public T[] Array { get; set; }
    }
}