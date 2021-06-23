using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

namespace UnityPlugins {
    public struct PlayerUtilities {
        public struct Math {
            public static bool IsDiagonal(Vector2 position1, Vector2 position2) => ((position1.x != position2.x) && (position1.y != position2.y));

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

            private static System.Random random = new System.Random(Guid.NewGuid()
                                                                        .GetHashCode());

            public static T RandomEnum<T>(int? seed = null) where T : Enum {
                if (seed != null) {
                    random = new System.Random((int)(seed));
                }
                Array values = Enum.GetValues(typeof(T));
                return (T)(values.GetValue(random.Next(values.Length)));
            }

            /// <summary>
            /// <paramref name="start"/> is inclusive, <paramref name="end"/> is not.
            /// </summary>
            /// <param name="start">Inclusive start.</param>
            /// <param name="end">Exclusive end.</param>
            /// <param name="seed">Optional seed parameter.</param>
            /// <typeparam name="T">An enum type to randomly select from.</typeparam>
            /// <returns>A random enum value.</returns>
            public static T RandomEnum<T>(int start,
                                          int end,
                                          int? seed = null) where T : Enum {
                if (seed != null) {
                    random = new System.Random((int)(seed));
                }
                Array values = Enum.GetValues(typeof(T));
                return (T)(values.GetValue(random.Next(start, end)));
            }

            /// <summary>
            /// Calculates Vector2 direction.
            /// </summary>
            /// <param name="position1">Starting position.</param>
            /// <param name="position2">Ending position.</param>
            /// <returns>Returns direction relative to <paramref name="position1"/>.</returns>
            public static Vector2 CalculateDirection(Vector2 position1, Vector2 position2) {
                Vector2 subtracted = (position1 - position2),
                        direction = Vector2.zero;
                if (subtracted.x > 0f) {
                    direction.x = -1f;
                } else if (subtracted.x != 0f) {
                    direction.x = 1f;
                }

                if (subtracted.y > 0f) {
                    direction.y = -1f;
                } else if (subtracted.y != 0f) {
                    direction.y = 1f;
                }

                return direction;
            }

            /// <summary>
            /// Calculates Vector3 direction.
            /// </summary>
            /// <param name="position1">Starting position.</param>
            /// <param name="position2">Ending position.</param>
            /// <returns>Returns distance relative to <paramref name="position1"/>.</returns>
            public static Vector3 CalculateDirection(Vector3 position1, Vector3 position2) {
                Vector3 subtracted = (position1 - position2),
                        direction = Vector3.zero;
                if (subtracted.x > 0f) {
                    direction.x = -1f;
                } else if (subtracted.x != 0f) {
                    direction.x = 1f;
                }

                if (subtracted.y > 0f) {
                    direction.y = -1f;
                } else if (subtracted.y != 0f) {
                    direction.y = 1f;
                }

                if (subtracted.z > 0f) {
                    direction.z = -1f;
                } else if (subtracted.z != 0f) {
                    direction.z = 1f;
                }

                return direction;
            }
        }

        public struct Input {
            public static int ParseInt(string input, int defaultReturn) => ((string.IsNullOrEmpty(input) == false) ? int.Parse(input) : defaultReturn);

            public static long ParseLong(string input, long defaultReturn) => ((string.IsNullOrEmpty(input) == false) ? long.Parse(input) : defaultReturn);

            public static RaycastHit MouseToHit(Camera camera) {
                Ray mouseRay = camera.ScreenPointToRay(UnityEngine.Input.mousePosition);
                Physics.Raycast(mouseRay,
                                out RaycastHit raycastHit,
                                1000f);
                return raycastHit;
            }

            public static IEnumerable<RaycastHit2D> MouseToHits2D(Camera camera) => Physics2D.RaycastAll(camera.ScreenToWorldPoint(UnityEngine.Input.mousePosition), Vector2.zero);
        }

        public struct Animation {
            public static void ChangeAnimation(Animator animator,
                                               string animationName,
                                               int index) {
                if (animator.GetCurrentAnimatorStateInfo(index)
                            .IsName(animationName) ==
                    false) {
                    animator.Play(animationName);
                }
                return;
            }
        }

        public struct Other {
            public static void PrintOutEnums<T>() => PrintOutEnums(typeof(T));

            public static void PrintOutEnums(Type enumType) {
                foreach (string enumName in Enum.GetNames(enumType)) {
                    Debug.Log(enumName);
                }
                return;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void PrintException(Exception exception,
                                              string message,
                                              Action<object> debugLogMethod) {
                string printMessage = "";
                if (string.IsNullOrEmpty(message) == false) {
                    printMessage = $"{message}\r\n";
                }
                printMessage += ($"{exception.Message}\r\n" + StackTraceUtility.ExtractStringFromException(exception));
                debugLogMethod(printMessage);
                return;
            }
        }
    }
}