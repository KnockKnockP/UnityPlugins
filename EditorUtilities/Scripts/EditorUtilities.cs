#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

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

        public static void MarkObjectAsDirty(Object target) {
#if UNITY_EDITOR
            EditorUtility.SetDirty(target);
#endif
            return;
        }

        public static GameObject Instantiate(Object assetComponentOrGameObject) {
#if UNITY_EDITOR
            return (GameObject)(PrefabUtility.InstantiatePrefab(assetComponentOrGameObject));
#else
            return null;
#endif
        }

        public static GameObject Instantiate(Object assetComponentOrGameObject, Scene destinationScene) {
#if UNITY_EDITOR
            return (GameObject)(PrefabUtility.InstantiatePrefab(assetComponentOrGameObject, destinationScene));
#else
            return null;
#endif
        }

        public static GameObject Instantiate(Object assetComponentOrGameObject, Transform parent) {
#if UNITY_EDITOR
            return (GameObject)(PrefabUtility.InstantiatePrefab(assetComponentOrGameObject, parent));
#else
            return null;
#endif
        }
    }
}