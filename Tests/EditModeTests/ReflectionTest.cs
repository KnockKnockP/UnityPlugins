using NUnit.Framework;
using System;
using System.Linq;

namespace UnityPlugins {
    namespace Tests {
        public static class ReflectionTest {
            private interface TestInterface {
                internal void TestInterfaceMethod();
            }

            private sealed class TestClass1 : TestInterface {
                void TestInterface.TestInterfaceMethod() {
                    return;
                }
            }

            private sealed class TestClass2 : TestInterface {
                void TestInterface.TestInterfaceMethod() {
                    return;
                }
            }

            [Test]
            public static void TestFindAllClassesImplementing() {
                Type[] classTypes = Reflection.FindAllClassesImplementing<TestInterface>().ToArray();
                Assert.AreEqual(2, classTypes.Length);
                Assert.IsTrue(classTypes.Contains(typeof(TestClass1)));
                Assert.IsTrue(classTypes.Contains(typeof(TestClass2)));
                return;
            }
        }
    }
}