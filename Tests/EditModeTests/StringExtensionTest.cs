using NUnit.Framework;
using UnityPlugins.Extension;

namespace UnityPlugins.Tests.EditMode {
    internal static class StringExtensionTest {
        [Test]
        public static void TestRemoveCharacters() {
            Assert.AreEqual("Tes sring", "Test string".RemoveCharacters('t'));
            Assert.AreEqual("est string", "Test string".RemoveCharacters('T'));
            Assert.AreEqual("es sring", "Test string".RemoveCharacters('T', 't'));
            Assert.AreEqual("\n가다", "\r\n가나다".RemoveCharacters('\r', '나'));
            
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
    }
}