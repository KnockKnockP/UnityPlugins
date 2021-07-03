using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
#endif

namespace UnityPlugins.EditorTool {
    /// <summary>
    /// A class that manages the scene.
    /// </summary>
    public static class SceneTool {
        /// <summary>
        /// Marks the active scene as dirty in the edit mode.
        /// </summary>
        public static void MarkSceneAsDirty() {
#if UNITY_EDITOR
            if (Application.isPlaying == false) {
                EditorSceneManager.MarkSceneDirty(SceneManager.GetActiveScene());
            }
#endif
        }

        /// <summary>
        /// Marks <paramref name="target"/> as dirty in the edit mode. <br />
        /// </summary>
        /// <param name="target">The <see cref="Object"/> to mark as dirty.</param>
        public static void MarkObjectAsDirty(Object target) {
#if UNITY_EDITOR
            EditorUtility.SetDirty(target);
#endif
            return;
        }
    }
}