#if UNITY_EDITOR
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityPlugins {
    public struct EditorUtilities {
        public static void MarkSceneAsDirty() {
            if (Application.isPlaying == false) {
                EditorSceneManager.MarkSceneDirty(SceneManager.GetActiveScene());
            } else {
                Debug.LogWarning($"{nameof(MarkSceneAsDirty)} can not be called in play mode.");
            }
        }
    }
}
#endif