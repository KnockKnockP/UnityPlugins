using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UnityPlugins {
    public static class Extensions {
        public static readonly Vector2[] directions = new Vector2[4] {
            Vector2.up,
            Vector2.left,
            Vector2.down,
            Vector2.right
        };

        public static bool IsSmallerThan<T>(this T value, T compare) where T : IComparable {
            return (value.CompareTo(compare) < 0);
        }

        public static bool IsGreaterThan<T>(this T value, T compare) where T : IComparable {
            return (value.CompareTo(compare) > 0);
        }

        public static string RemoveBannedCharacters(this string original, string bannedCharacters) {
            string newString = "";
            foreach (char _char in original) {
                if (bannedCharacters.Contains(_char.ToString()) == false) {
                    newString += _char;
                }
            }
            return newString;
        }

        public static string TrimStart(this string target, string trimString) {
            if (string.IsNullOrEmpty(trimString) == true) {
                return target;
            }

            string result = target;
            while (result.StartsWith(trimString) == true) {
                result = result.Substring(trimString.Length);
            }

            return result;
        }

        public static string TrimEnd(this string target, string trimString) {
            if (string.IsNullOrEmpty(trimString) == true) {
                return target;
            }

            string result = target;
            while (result.EndsWith(trimString) == true) {
                result = result.Substring(0, (result.Length - trimString.Length));
            }

            return result;
        }

        public static Vector2Int ToVector2Int(this Vector2 target) {
            return new Vector2Int((int)(target.x), (int)(target.y));
        }

        public static Vector2 ToVector2(this Vector2Int target) {
            return new Vector2(target.x, target.y);
        }

        public static Vector3Int ToVector3Int(this Vector3 target) {
            return new Vector3Int((int)(target.x), (int)(target.y), (int)(target.z));
        }

        public static Vector2Int ToVector2Int(this Vector3 target) {
            return new Vector2Int((int)(target.x), (int)(target.y));
        }

        public static Vector3 ToVector3(this Vector3Int target) {
            return new Vector3(target.x, target.y, target.z);
        }

        public static ColorBlock GenerateColorBlocks(this ColorBlock originalColorBlock, Color32 newColor) {
            ColorBlock colorBlock = new ColorBlock {
                normalColor = newColor,
                highlightedColor = new Color32((byte)(PlayerUtilities.Math.Clamp((newColor.r + 10),
                                                                                     byte.MinValue,
                                                                                     byte.MaxValue)),
                                                       (byte)(PlayerUtilities.Math.Clamp((newColor.g + 20),
                                                                                     byte.MinValue,
                                                                                     byte.MaxValue)),
                                                       (byte)(PlayerUtilities.Math.Clamp((newColor.b + 10),
                                                                                     byte.MinValue,
                                                                                     byte.MaxValue)),
                                                       byte.MaxValue),
                pressedColor = new Color32((byte)(PlayerUtilities.Math.Clamp((newColor.r - 30),
                                                                                     byte.MinValue,
                                                                                     byte.MaxValue)),
                                                   (byte)(PlayerUtilities.Math.Clamp((newColor.g - 30),
                                                                                     byte.MinValue,
                                                                                     byte.MaxValue)),
                                                   (byte)(PlayerUtilities.Math.Clamp((newColor.b - 30),
                                                                                     byte.MinValue,
                                                                                     byte.MaxValue)),
                                                   byte.MaxValue),
                selectedColor = newColor,
                disabledColor = new Color32((byte)(PlayerUtilities.Math.Clamp((newColor.r * 0.6f),
                                                                                     byte.MinValue,
                                                                                     byte.MaxValue)),
                                                   (byte)(PlayerUtilities.Math.Clamp((newColor.g * 0.6f),
                                                                                     byte.MinValue,
                                                                                     byte.MaxValue)),
                                                   (byte)(PlayerUtilities.Math.Clamp((newColor.b * 0.6f),
                                                                                     byte.MinValue,
                                                                                     byte.MaxValue)),
                                                   byte.MaxValue),
                colorMultiplier = originalColorBlock.colorMultiplier,
                fadeDuration = originalColorBlock.fadeDuration
            };
            return colorBlock;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void UnityLog(this object message) {
            Debug.Log(message);
            return;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void UnityLogWarning(this object message) {
            Debug.LogWarning(message);
            return;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void UnityLogError(this object message) {
            Debug.LogError(message);
            return;
        }
    }
}