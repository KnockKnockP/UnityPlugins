#if UNITY_EDITOR
using System;
using System.Globalization;
using UnityEditor;
using UnityEngine;

namespace UnityPlugins {
    public class VersionManager : MonoBehaviour {
        [SerializeField] private GameObject[] MainBuildDisableObjects = null;

        public void Awake() {
            foreach (GameObject _gameObject in MainBuildDisableObjects) {
                _gameObject.SetActive(Debug.isDebugBuild);
            }
            return;
        }
    }

    [CustomEditor(typeof(VersionManager))]
    public class VersionManagerOverride : Editor {
        public override void OnInspectorGUI() {
            base.OnInspectorGUI();
            if (GUILayout.Button("Generate new version number.") == true) {
                GenerateNewVersionNumber();
            }
            return;
        }

        private void GenerateNewVersionNumber() {
            Debug.Log($"New version : {DateTime.Now.ToString("TESTBUILD-yyyy-MM-ddThh-mm-tt+0900", CultureInfo.InvariantCulture)}\r\n");
            Debug.LogError("Do not forget to enter the password.");
            return;
        }
    }
}
#endif