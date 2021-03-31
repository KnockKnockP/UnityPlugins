using System;
using System.Globalization;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

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

#if UNITY_EDITOR
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
            string version = DateTime.Now.ToString("TESTBUILD-yyyy-MM-ddThh-mm-tt+0900", CultureInfo.InvariantCulture);
            GUIUtility.systemCopyBuffer = PlayerSettings.bundleVersion = version;
            Debug.Log($"New version : {version}\r\n");
            Debug.LogError("Do not forget to enter the password.");
            return;
        }
    }
#endif
}