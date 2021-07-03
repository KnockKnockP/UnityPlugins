using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityPlugins.EditorTool {
    /// <summary>
    ///     A class that instantiates a <see cref="GameObject" /> in both edit and play mode.
    /// </summary>
    public static class InstantiateTool {
        /// <summary>
        ///     Instantiates <paramref name="original" />. <br />
        ///     This method is for both edit and play mode.
        /// </summary>
        /// <param name="original">A <see cref="GameObject" /> to instantiate.</param>
        /// <returns>An instantiated <paramref name="original" /> instance.</returns>
        public static GameObject PlayAndEditInstantiate(GameObject original) => ((Application.isPlaying == true) ? Object.Instantiate(original) : Instantiate(original));

        /// <summary>
        ///     Instantiates a <paramref name="assetComponentOrGameObject" /> in editor.
        /// </summary>
        /// <param name="assetComponentOrGameObject">An <see cref="Object" /> to instantiate.</param>
        /// <returns>
        ///     Returns an instantiated instance of <paramref name="assetComponentOrGameObject" />. <br />
        ///     Returns null when the method is called outside of the editor.
        /// </returns>
        public static GameObject Instantiate(Object assetComponentOrGameObject) {
#if UNITY_EDITOR
            return (GameObject)(PrefabUtility.InstantiatePrefab(assetComponentOrGameObject));
#else
            return null;
#endif
        }

        /// <summary>
        ///     Instantiates a <paramref name="assetComponentOrGameObject" /> in <paramref name="destinationScene" /> in editor.
        /// </summary>
        /// <param name="assetComponentOrGameObject">An <see cref="Object" /> to instantiate.</param>
        /// <param name="destinationScene">A scene to instantiate <paramref name="assetComponentOrGameObject" /> in.</param>
        /// <returns>
        ///     Returns an instantiated instance of <paramref name="assetComponentOrGameObject" />. <br />
        ///     Returns null when the method is called outside of the editor.
        /// </returns>
        public static GameObject Instantiate(Object assetComponentOrGameObject, Scene destinationScene) {
#if UNITY_EDITOR
            return (GameObject)(PrefabUtility.InstantiatePrefab(assetComponentOrGameObject, destinationScene));
#else
            return null;
#endif
        }

        /// <summary>
        ///     Instantiates a <paramref name="assetComponentOrGameObject" /> with a parent of <paramref name="parent" />.
        /// </summary>
        /// <param name="assetComponentOrGameObject">An <see cref="Object" /> to instantiate.</param>
        /// <param name="parent">An object to be used as a parent.</param>
        /// <returns>
        ///     Returns an instantiated instance of <paramref name="assetComponentOrGameObject" />. <br />
        ///     Returns null when the method is called outside of the editor.
        /// </returns>
        public static GameObject Instantiate(Object assetComponentOrGameObject, Transform parent) {
#if UNITY_EDITOR
            return (GameObject)(PrefabUtility.InstantiatePrefab(assetComponentOrGameObject, parent));
#else
            return null;
#endif
        }
    }
}