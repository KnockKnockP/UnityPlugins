using NUnit.Framework;
using UnityEngine;

namespace UnityPlugins {
    namespace Tests {
        internal static class ExtensionsTest {
            [Test]
            public static void TestDirections() {
                Assert.AreEqual(new Vector2(0f, 1f), Extensions.Directions[0]);
                Assert.AreEqual(new Vector2(-1f, 0f), Extensions.Directions[1]);
                Assert.AreEqual(new Vector2(0f, -1f), Extensions.Directions[2]);
                Assert.AreEqual(new Vector2(1f, 0f), Extensions.Directions[3]);
                return;
            }

            [Test]
            public static void TestIsSmallerThan() {
                //Value must be smaller than compare for this test to succeed.
                Assert.IsTrue(1.IsSmallerThan(42));
                Assert.IsTrue((-500).IsSmallerThan(500));
                Assert.IsFalse(5.IsSmallerThan(2));
                Assert.IsFalse(100.IsSmallerThan(20));
                return;
            }

            [Test]
            public static void TestIsBiggerThan() {
                //Value must be bigger than compare for this test to succeed.
                Assert.IsTrue(5.IsGreaterThan(2));
                Assert.IsTrue(100.IsGreaterThan(20));
                Assert.IsFalse(1.IsGreaterThan(42));
                Assert.IsFalse((-500).IsGreaterThan(500));
                return;
            }

            [Test]
            public static void TestRemoveCharacters() {
                Assert.AreEqual("Tes sring", "Test string".RemoveCharacters("t"));
                Assert.AreEqual("est string", "Test string".RemoveCharacters("T"));
                Assert.AreEqual("es sring", "Test string".RemoveCharacters("Tt"));
                Assert.AreEqual("\n가다", "\r\n가나다".RemoveCharacters("\r나"));
                return;
            }

            [Test]
            public static void TestTrimStart() {
                Assert.AreEqual(" string", "Test string".TrimStart("Test"));
                Assert.AreEqual("다", "abc가나다".TrimStart("abc가나"));
                Assert.AreEqual("Test string", "Test string".TrimStart("string"));
                Assert.AreEqual("ㅡ가나다", "ㅡ가나다".TrimStart("가나다"));
                return;
            }

            [Test]
            public static void TestTrimEnd() {
                Assert.AreEqual("Test ", "Test string".TrimEnd("string"));
                Assert.AreEqual("가나", "가나다abc".TrimEnd("다abc"));
                Assert.AreEqual("Test string", "Test string".TrimEnd("Test s"));
                Assert.AreEqual("가나다abc", "가나다abc".TrimEnd("가나다a"));
                return;
            }

            [Test]
            public static void TestToVector2Int() {
                Assert.AreEqual(new Vector2Int(1, 5), new Vector2(1f, 5f).ToVector2Int());
                Assert.AreEqual(new Vector2Int(-5, 10), new Vector2(-5f, 10f).ToVector2Int());
                Assert.AreEqual(new Vector2Int(0, 2), new Vector2(0.1f, 2.6f).ToVector2Int());
                Assert.AreEqual(new Vector2Int(-1, -9), new Vector2(-1.9f, -9.1f).ToVector2Int());

                Assert.AreEqual(new Vector2Int(1, 5),
                                new Vector3(1f,
                                            5f,
                                            2f).ToVector2Int());
                Assert.AreEqual(new Vector2Int(-5, 10),
                                new Vector3(-5f,
                                            10f,
                                            0f).ToVector2Int());
                Assert.AreEqual(new Vector2Int(0, 2),
                                new Vector3(0.1f,
                                            2.6f,
                                            1.9f).ToVector2Int());
                Assert.AreEqual(new Vector2Int(-1, -9),
                                new Vector3(-1.9f,
                                            -9.1f,
                                            -4.5f).ToVector2Int());
                return;
            }

            [Test]
            public static void TestToVector2() {
                Assert.AreEqual(new Vector2(0f, 1f), new Vector2Int(0, 1).ToVector2());
                Assert.AreEqual(new Vector2(100f, 20f), new Vector2Int(100, 20).ToVector2());
                Assert.AreEqual(new Vector2(-10f, 0f), new Vector2Int(-10, 0).ToVector2());
                Assert.AreEqual(new Vector2(-5f, -30f), new Vector2Int(-5, -30).ToVector2());
                return;
            }

            [Test]
            public static void TestToVector3Int() {
                Assert.AreEqual(new Vector3Int(5,
                                               0,
                                               2),
                                new Vector3(5f,
                                            0f,
                                            2f).ToVector3Int());
                Assert.AreEqual(new Vector3Int(-5,
                                               -3,
                                               9),
                                new Vector3(-5f,
                                            -3f,
                                            9f).ToVector3Int());
                Assert.AreEqual(new Vector3Int(0,
                                               2,
                                               7),
                                new Vector3(0.1f,
                                            2.5f,
                                            7.9f).ToVector3Int());
                Assert.AreEqual(new Vector3Int(-4,
                                               -3,
                                               9),
                                new Vector3(-4.3f,
                                            -3.4f,
                                            9f).ToVector3Int());
                return;
            }

            [Test]
            public static void TestToVector3() {
                Assert.AreEqual(new Vector3(0f,
                                            2f,
                                            5f),
                                new Vector3Int(0,
                                               2,
                                               5).ToVector3());
                Assert.AreEqual(new Vector3(200f,
                                            900f,
                                            50f),
                                new Vector3Int(200,
                                               900,
                                               50).ToVector3());
                Assert.AreEqual(new Vector3(-9f,
                                            -20f,
                                            4f),
                                new Vector3Int(-9,
                                               -20,
                                               4).ToVector3());
                Assert.AreEqual(new Vector3(-100f,
                                            -500f,
                                            -42),
                                new Vector3Int(-100,
                                               -500,
                                               -42).ToVector3());
                return;
            }
        }
    }
}