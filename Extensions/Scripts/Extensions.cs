using System;
using System.Collections.Generic;

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
    }
}