using NUnit.Framework;
using UnityEngine;
using UnityPlugins.Extension;

namespace UnityPlugins.Tests.EditMode {
    internal static class Vector2ExtensionTest {
        [Test]
        public static void TestDirections() {
            Assert.AreEqual(new Vector2(0f, 1f), Vector2Extension.Directions[0]);
            Assert.AreEqual(new Vector2(-1f, 0f), Vector2Extension.Directions[1]);
            Assert.AreEqual(new Vector2(0f, -1f), Vector2Extension.Directions[2]);
            Assert.AreEqual(new Vector2(1f, 0f), Vector2Extension.Directions[3]);
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
    }
}