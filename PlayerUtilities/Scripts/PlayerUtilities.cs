using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UnityPlugins {
    public struct PlayerUtilities {
        public struct Math {
            //Returns true if the distance between is longer than the maxDistance.
            public static bool IsDiagonal(Vector2 position1, Vector2 position2) {
                return ((position1.x != position2.x) && (position1.y != position2.y));
            }

            public static T Clamp<T>(T value,
                                     T min,
                                     T max) where T : IComparable {
                if (value.IsSmallerThan(min) == true) {
                    value = min;
                } else if (value.IsGreaterThan(max) == true) {
                    value = max;
                }
                return value;
            }

            private static System.Random random = new System.Random(Guid.NewGuid().GetHashCode());

            public static T RandomEnum<T>(int? seed = null) where T : Enum {
                if (seed != null) {
                    random = new System.Random((int)(seed));
                }
                Array values = Enum.GetValues(typeof(T));
                return (T)(values.GetValue(random.Next(values.Length)));
            }

            //Start is inclusive, end is not.
            public static T RandomEnum<T>(int start,
                                          int end,
                                          int? seed = null) where T : Enum {
                if (seed != null) {
                    random = new System.Random((int)(seed));
                }
                Array values = Enum.GetValues(typeof(T));
                return (T)(values.GetValue(random.Next(start, end)));
            }

            //Returns direction relative to position1.
            public static Vector2 CalculateDirection(Vector2 position1, Vector2 position2) {
                if (position1.x > position2.x) {
                    return Vector2.left;
                } else if (position2.x > position1.x) {
                    return Vector2.right;
                } else if (position1.y > position2.y) {
                    return Vector2.down;
                } else if (position2.y > position1.y) {
                    return Vector2.up;
                } else {
                    return Vector2.zero;
                }
            }
        }

        public struct Input {
            public static int ParseInt(string input, int defaultReturn) {
                return ((string.IsNullOrEmpty(input) == false) ? int.Parse(input) : defaultReturn);
            }

            public static long ParseLong(string input, long defaultReturn) {
                return ((string.IsNullOrEmpty(input) == false) ? long.Parse(input) : defaultReturn);
            }

            public static Vector2 MouseToWorld(Vector2 mousePosition, Camera camera) {
                return camera.ScreenToWorldPoint(mousePosition);
            }

            public static IEnumerable<RaycastHit2D> MouseToHits(Camera camera) {
                return Physics2D.RaycastAll(MouseToWorld(UnityEngine.Input.mousePosition, camera), Vector2.zero);
            }
        }

        public struct Animation {
            public static void ChangeAnimation(Animator animator,
                                               string animationName,
                                               int index) {
                if (animator.GetCurrentAnimatorStateInfo(index).IsName(animationName) == false) {
                    animator.Play(animationName);
                }
                return;
            }
        }

        public struct Other {
            public static void PrintOutEnums<T>() {
                PrintOutEnums(typeof(T));
                return;
            }

            public static void PrintOutEnums(Type enumType) {
                foreach (string enumName in Enum.GetNames(enumType)) {
                    Debug.Log(enumName);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void PrintException(Exception exception,
                                              string message,
                                              Action<object> debugLogMethod) {
                string printMessage = "";
                if ((message != null) && (message != "")) {
                    printMessage = $"{message}\r\n";
                }
                printMessage += ($"{exception.Message}\r\n" + StackTraceUtility.ExtractStringFromException(exception));
                debugLogMethod(printMessage);
                return;
            }
        }
    }
}