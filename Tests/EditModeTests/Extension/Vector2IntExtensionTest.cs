using NUnit.Framework;
using UnityEngine;
using UnityPlugins.Extension;

namespace UnityPlugins.Tests.EditMode {
    internal static class Vector2IntExtensionTest {
        [Test]
        public static void TestToVector2() {
            Assert.AreEqual(new Vector2(0f, 1f), new Vector2Int(0, 1).ToVector2());
            Assert.AreEqual(new Vector2(100f, 20f), new Vector2Int(100, 20).ToVector2());
            Assert.AreEqual(new Vector2(-10f, 0f), new Vector2Int(-10, 0).ToVector2());
            Assert.AreEqual(new Vector2(-5f, -30f), new Vector2Int(-5, -30).ToVector2());
            return;
        }
    }
}