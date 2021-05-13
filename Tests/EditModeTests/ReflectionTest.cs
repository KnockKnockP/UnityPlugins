using NUnit.Framework;
using System;
using System.Linq;

namespace UnityPlugins {
    namespace Tests {
        namespace EditMode {
            public static class ReflectionTest {
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

                [Test]
                public static void TestFindAllClassesImplementing() {
                    Type[] classTypes = Reflection.FindAllClassesImplementing<ITestInterface>().ToArray();
                    Assert.AreEqual(2, classTypes.Length);
                    Assert.IsTrue(classTypes.Contains(typeof(TestClass1)));
                    Assert.IsTrue(classTypes.Contains(typeof(TestClass2)));
                    return;
                }
            }
        }
    }
}