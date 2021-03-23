using UnityEngine;
using UnityEngine.SceneManagement;
using System;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
#endif

namespace UnityPlugins {
    public struct EditorUtilities {
        public static void MarkSceneAsDirty() {
#if UNITY_EDITOR
            if (Application.isPlaying == false) {
                EditorSceneManager.MarkSceneDirty(SceneManager.GetActiveScene());
            }
#endif
            return;
        }

        public static void MarkObjectAsDirty(UnityEngine.Object target) {
#if UNITY_EDITOR
            EditorUtility.SetDirty(target);
#endif
            return;
        }

        public static GameObject PlayAndEditInstantiate(GameObject original) {
            if (Application.isPlaying == true) {
                return UnityEngine.Object.Instantiate(original);
            } else {
                return Instantiate(original);
            }
        }

        public static GameObject Instantiate(UnityEngine.Object assetComponentOrGameObject) {
#if UNITY_EDITOR
            return (GameObject)(PrefabUtility.InstantiatePrefab(assetComponentOrGameObject));
#else
            return null;
#endif
        }

        public static GameObject Instantiate(UnityEngine.Object assetComponentOrGameObject, Scene destinationScene) {
#if UNITY_EDITOR
            return (GameObject)(PrefabUtility.InstantiatePrefab(assetComponentOrGameObject, destinationScene));
#else
            return null;
#endif
        }

        public static GameObject Instantiate(UnityEngine.Object assetComponentOrGameObject, Transform parent) {
#if UNITY_EDITOR
            return (GameObject)(PrefabUtility.InstantiatePrefab(assetComponentOrGameObject, parent));
#else
            return null;
#endif
        }

        public static void PrintEnums<T>() {
#if UNITY_EDITOR
            GUILayout.Label("\r\n" +
                              $"{typeof(T)}", EditorStyles.boldLabel);
            foreach (string enumName in Enum.GetNames(typeof(T))) {
                GUILayout.Label(enumName, EditorStyles.miniLabel);
            }
#endif
            return;
        }
    }
}