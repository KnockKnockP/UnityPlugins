using NUnit.Framework;
using System;
using System.Linq;

namespace UnityPlugins.Tests.EditMode {
    internal static class ReflectionTest {
        #region GetEnums.
        private enum TestEnum {
            A = 0,
            B = 1,
            C = 2
        }

        [Test]
        public static void TestGetEnums() {
            TestEnum[] enumValues = ReflectionTool.GetEnumValues<TestEnum>();
            Assert.AreEqual(3, enumValues.Length);
            Assert.IsTrue(enumValues.Contains(TestEnum.A));
            Assert.IsTrue(enumValues.Contains(TestEnum.B));
            Assert.IsTrue(enumValues.Contains(TestEnum.C));
            return;
        }
        #endregion

        #region FindAllClassesImplementing
        #region Test classes.
        private interface ITestInterface {
            internal void TestInterfaceMethod();
        }

        private sealed class TestClass1 : ITestInterface {
            void ITestInterface.TestInterfaceMethod() {
                return;
            }
        }

        private sealed class TestClass2 : ITestInterface {
            void ITestInterface.TestInterfaceMethod() {
                return;
            }
        }
        #endregion

        [Test]
        public static void TestFindAllClassesImplementing() {
            Type[] classTypes = ReflectionTool.FindAllClassesImplementing<ITestInterface>()
                                              .ToArray();
            Assert.AreEqual(2, classTypes.Length);
            Assert.IsTrue(classTypes.Contains(typeof(TestClass1)));
            Assert.IsTrue(classTypes.Contains(typeof(TestClass2)));
            return;
        }
        #endregion
    }
}