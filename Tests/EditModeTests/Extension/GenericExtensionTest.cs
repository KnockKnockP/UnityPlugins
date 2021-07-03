using NUnit.Framework;
using UnityPlugins.Extension;

namespace UnityPlugins.Tests.EditMode {
    internal static class GenericExtensionTest {
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
    }
}