using NUnit.Framework;
using UnityEngine;
using UnityPlugins.Extension;

namespace UnityPlugins.Tests.EditMode {
    internal static class Vector3IntExtensionTest {
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