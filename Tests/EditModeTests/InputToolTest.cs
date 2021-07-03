using NUnit.Framework;

namespace UnityPlugins.Tests.EditMode {
    internal static class InputToolTest {
        [Test]
        public static void TestParseInt() {
            Assert.AreEqual(0, InputTool.ParseInt("0", 5));
            Assert.AreEqual(-10000, InputTool.ParseInt("-10000", 0));
            Assert.AreEqual(20, InputTool.ParseInt(string.Empty, 20));
            Assert.AreEqual(-30, InputTool.ParseInt(null, -30));
            return;
        }

        [Test]
        public static void TestParseLong() {
            Assert.AreEqual(0, InputTool.ParseLong("0", 5));
            Assert.AreEqual(-1000000000000000000, InputTool.ParseLong("-1000000000000000000", 0));
            Assert.AreEqual(1000000000000000000, InputTool.ParseLong(string.Empty, 1000000000000000000));
            Assert.AreEqual(-500, InputTool.ParseLong(null, -500));
            return;
        }
    }
}