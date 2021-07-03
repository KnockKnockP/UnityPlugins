using System;
using UnityEditor;
using UnityEngine;

namespace UnityPlugins.EditorTool {
    /// <summary>
    /// A class that contains Unity editor GUI tools.
    /// </summary>
    public static class GUITool {
        /// <summary>
        /// Creates a label for all of the enum values specified in the <typeparamref name="TEnum"/> enum type.
        /// </summary>
        /// <param name="guiStyle">A GUI style used by the enum value label.</param>
        /// <typeparam name="TEnum">An enum type to be labeled.</typeparam>
        public static void LabelEnums<TEnum>(GUIStyle guiStyle) where TEnum : Enum {
#if UNITY_EDITOR
            GUILayout.Label("\r\n" + $"{typeof(TEnum)}", EditorStyles.boldLabel);
            foreach (string enumName in Enum.GetNames(typeof(TEnum))) {
                GUILayout.Label(enumName, guiStyle);
            }
#endif
            return;
        }
    }
}