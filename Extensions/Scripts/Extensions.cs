using System;

namespace UnityPlugins {
    public static class Extensions {
        public static bool IsSmallerThan<T>(this T value, T compare) where T : IComparable {
            return (value.CompareTo(compare) < 0);
        }

        public static bool IsGreaterThan<T>(this T value, T compare) where T : IComparable {
            return (value.CompareTo(compare) > 0);
        }
    }
}