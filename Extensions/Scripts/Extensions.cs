using System;
using UnityEngine;
using UnityEngine.UI;

namespace UnityPlugins {
    public static class Extensions {
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

        public static ColorBlock GenerateButtonColors(this ColorBlock originalColorBlock, Color32 newColor) {
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
    }
}