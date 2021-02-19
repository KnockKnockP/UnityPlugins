#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
#endif

namespace UnityPlugins {
    public struct EditorUtilities {
        public static void MarkSceneAsDirty() {
#if UNITY_EDITOR
            if (Application.isPlaying == false) {
                EditorSceneManager.MarkSceneDirty(SceneManager.GetActiveScene());
            } else {
                Debug.LogWarning($"{nameof(MarkSceneAsDirty)} can not be called in play mode.");
            }
#endif
            return;
        }

        public static GameObject Instantiate(Object assetComponentOrGameObject) {
#if UNITY_EDITOR
            return (GameObject)(PrefabUtility.InstantiatePrefab(assetComponentOrGameObject));
#endif
        }

        public static GameObject Instantiate(Object assetComponentOrGameObject, Scene destinationScene) {
#if UNITY_EDITOR
            return (GameObject)(PrefabUtility.InstantiatePrefab(assetComponentOrGameObject, destinationScene));
#endif
        }

        public static GameObject Instantiate(Object assetComponentOrGameObject, Transform parent) {
#if UNITY_EDITOR
            return (GameObject)(PrefabUtility.InstantiatePrefab(assetComponentOrGameObject, parent));
#endif
        }
    }
}