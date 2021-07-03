using NUnit.Framework;
using UnityEngine;
using UnityPlugins.Extension;

namespace UnityPlugins.Tests.EditMode {
    internal static class Vector3ExtensionTest {
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
    }
}