#if UNITY_EDITOR
using System;
using System.Globalization;
using UnityEditor;
using UnityEngine;
#endif

namespace UnityPlugins.UserEditor {
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

        private static void GenerateNewVersionNumber() {
            string version = DateTime.Now.ToString("TESTBUILD-yyyy-MM-ddThh-mm-tt+0900", CultureInfo.InvariantCulture);
            GUIUtility.systemCopyBuffer = PlayerSettings.bundleVersion = version;
            Debug.Log($"New version : {version}\r\n");
            return;
        }
    }
#endif
}