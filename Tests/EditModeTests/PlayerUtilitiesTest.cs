using NUnit.Framework;
using UnityEngine;

namespace UnityPlugins {
    namespace Tests {
        public static class PlayerUtilitiesTest {
            private enum TestEnum : byte {
                Enum0 = 0,
                Enum1 = 1,
                Enum2 = 2,
                Enum3 = 3,
                Enum4 = 4
            }

            [Test]
            public static void TestIsDiagonal() {
                Assert.IsTrue(PlayerUtilities.Math.IsDiagonal(new UnityEngine.Vector2(0f, 0f), new UnityEngine.Vector2(1f, 1f)));
                Assert.IsTrue(PlayerUtilities.Math.IsDiagonal(new UnityEngine.Vector2(0.1f, 0.2f), new UnityEngine.Vector2(-5.2f, -10.5f)));
                Assert.IsFalse(PlayerUtilities.Math.IsDiagonal(new UnityEngine.Vector2(0f, 0f), new UnityEngine.Vector2(1f, 0f)));
                Assert.IsFalse(PlayerUtilities.Math.IsDiagonal(new UnityEngine.Vector2(5f, -5f), new UnityEngine.Vector2(5f, -10f)));
                return;
            }

            [Test]
            public static void TestClamp() {
                Assert.AreEqual(100,
                                PlayerUtilities.Math.Clamp<byte>(100,
                                                                 0,
                                                                 101));
                Assert.AreEqual(200,
                                PlayerUtilities.Math.Clamp(500,
                                                           0,
                                                           200));
                Assert.AreEqual(-10.2f,
                                PlayerUtilities.Math.Clamp(-20f,
                                                           -10.2f,
                                                           0f));
                Assert.IsTrue(PlayerUtilities.Math.Clamp(true,
                                                         false,
                                                         true));
                return;
            }

            [Test]
            public static void TestCalculateDirection() {
                Assert.AreEqual(new Vector2(0f, 1f), PlayerUtilities.Math.CalculateDirection(new Vector2(0f, 5.2f), new Vector2(0f, 10.2f)));
                Assert.AreEqual(new Vector2(-1f, 0f), PlayerUtilities.Math.CalculateDirection(new Vector2(2.5f, 0f), new Vector2(-19.5f, 0f)));
                Assert.AreEqual(new Vector2(0f, -1f), PlayerUtilities.Math.CalculateDirection(new Vector2(3.2f, -5.9f), new Vector2(3.2f, -8.9f)));
                Assert.AreEqual(new Vector2(1f, 0f), PlayerUtilities.Math.CalculateDirection(new Vector2(-5.9f, -2.3f), new Vector2(9.2f, -2.3f)));
                return;
            }

            [Test]
            public static void TestParseInt() {
                Assert.AreEqual(0, PlayerUtilities.Input.ParseInt("0", 5));
                Assert.AreEqual(-10000, PlayerUtilities.Input.ParseInt("-10000", 0));
                Assert.AreEqual(20, PlayerUtilities.Input.ParseInt("", 20));
                Assert.AreEqual(-30, PlayerUtilities.Input.ParseInt(null, -30));
                return;
            }

            [Test]
            public static void TestParseLong() {
                Assert.AreEqual(0, PlayerUtilities.Input.ParseLong("0", 5));
                Assert.AreEqual(-1000000000000000000, PlayerUtilities.Input.ParseLong("-1000000000000000000", 0));
                Assert.AreEqual(1000000000000000000, PlayerUtilities.Input.ParseLong("", 1000000000000000000));
                Assert.AreEqual(-500, PlayerUtilities.Input.ParseLong(null, -500));
                return;
            }
        }
    }
}