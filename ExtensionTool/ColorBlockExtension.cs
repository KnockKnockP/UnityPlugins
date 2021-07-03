using UnityEngine;
using UnityEngine.UI;

namespace UnityPlugins.Extension {
    /// <summary>
    ///     A class that contains <see cref="ColorBlock" /> extension methods.
    /// </summary>
    public static class ColorBlockExtension {
        /// <summary>
        ///     Generates a new <see cref="ColorBlock" /> based on <paramref name="originalColorBlock" /> settings and <paramref name="newColor" />.
        /// </summary>
        /// <param name="originalColorBlock">A base <see cref="ColorBlock" /> instance.</param>
        /// <param name="newColor">A color to be applied to the new <see cref="ColorBlock" />.</param>
        /// <returns>The same <see cref="ColorBlock" /> but with different colors.</returns>
        public static ColorBlock GenerateColorBlock(this ColorBlock originalColorBlock, Color32 newColor) {
            ColorBlock colorBlock = new ColorBlock {
                normalColor = newColor,
                highlightedColor = new Color32((byte)(MathTool.Clamp((newColor.r + 10),
                                                                     byte.MinValue,
                                                                     byte.MaxValue)),
                                               (byte)(MathTool.Clamp((newColor.g + 20),
                                                                     byte.MinValue,
                                                                     byte.MaxValue)),
                                               (byte)(MathTool.Clamp((newColor.b + 10),
                                                                     byte.MinValue,
                                                                     byte.MaxValue)),
                                               byte.MaxValue),
                pressedColor = new Color32((byte)(MathTool.Clamp((newColor.r - 30),
                                                                 byte.MinValue,
                                                                 byte.MaxValue)),
                                           (byte)(MathTool.Clamp((newColor.g - 30),
                                                                 byte.MinValue,
                                                                 byte.MaxValue)),
                                           (byte)(MathTool.Clamp((newColor.b - 30),
                                                                 byte.MinValue,
                                                                 byte.MaxValue)),
                                           byte.MaxValue),
                selectedColor = newColor,
                disabledColor = new Color32((byte)(MathTool.Clamp((newColor.r * 0.6f),
                                                                  byte.MinValue,
                                                                  byte.MaxValue)),
                                            (byte)(MathTool.Clamp((newColor.g * 0.6f),
                                                                  byte.MinValue,
                                                                  byte.MaxValue)),
                                            (byte)(MathTool.Clamp((newColor.b * 0.6f),
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