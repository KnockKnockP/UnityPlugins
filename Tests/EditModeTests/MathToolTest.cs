using NUnit.Framework;
using UnityEngine;

namespace UnityPlugins.Tests.EditMode {
    internal static class MathToolTest {
        [Test]
        public static void TestIsDiagonal() {
            Assert.IsTrue(MathTool.IsDiagonal(new Vector2(0f, 0f), new Vector2(1f, 1f)));
            Assert.IsTrue(MathTool.IsDiagonal(new Vector2(0.1f, 0.2f), new Vector2(-5.2f, -10.5f)));
            Assert.IsFalse(MathTool.IsDiagonal(new Vector2(0f, 0f), new Vector2(1f, 0f)));
            Assert.IsFalse(MathTool.IsDiagonal(new Vector2(5f, -5f), new Vector2(5f, -10f)));
            return;
        }

        [Test]
        public static void TestClamp() {
            Assert.AreEqual(100,
                            MathTool.Clamp<byte>(100,
                                                 0,
                                                 101));
            Assert.AreEqual(200,
                            MathTool.Clamp(500,
                                           0,
                                           200));
            Assert.AreEqual(-10.2f,
                            MathTool.Clamp(-20f,
                                           -10.2f,
                                           0f));
            Assert.IsTrue(MathTool.Clamp(true,
                                         false,
                                         true));
            return;
        }

        [Test]
        public static void TestCalculateDirection() {
            Assert.AreEqual(new Vector2(0f, 0f), MathTool.CalculateDirection(new Vector2(-8.75f, 32.2f), new Vector2(-8.75f, 32.2f)));
            Assert.AreEqual(new Vector2(0f, 1f), MathTool.CalculateDirection(new Vector2(0f, 5.2f), new Vector2(0f, 10.2f)));
            Assert.AreEqual(new Vector2(-1f, 0f), MathTool.CalculateDirection(new Vector2(2.5f, 0f), new Vector2(-19.5f, 0f)));
            Assert.AreEqual(new Vector2(0f, -1f), MathTool.CalculateDirection(new Vector2(3.2f, -5.9f), new Vector2(3.2f, -8.9f)));
            Assert.AreEqual(new Vector2(1f, 0f), MathTool.CalculateDirection(new Vector2(-5.9f, -2.3f), new Vector2(9.2f, -2.3f)));

            Assert.AreEqual(new Vector3(0f,
                                        0f,
                                        0f),
                            MathTool.CalculateDirection(new Vector3(94.3f,
                                                                    -25.2f,
                                                                    76.287f),
                                                        new Vector3(94.3f,
                                                                    -25.2f,
                                                                    76.287f)));
            Assert.AreEqual(new Vector3(0f,
                                        1f,
                                        -1f),
                            MathTool.CalculateDirection(new Vector3(0f,
                                                                    5.2f,
                                                                    2f),
                                                        new Vector3(0f,
                                                                    10.2f,
                                                                    -1.4f)));
            Assert.AreEqual(new Vector3(-1f,
                                        0f,
                                        0f),
                            MathTool.CalculateDirection(new Vector3(2.5f,
                                                                    0f,
                                                                    2.5f),
                                                        new Vector3(-19.5f,
                                                                    0f,
                                                                    2.5f)));
            Assert.AreEqual(new Vector3(0f,
                                        -1f,
                                        1f),
                            MathTool.CalculateDirection(new Vector3(3.2f,
                                                                    -5.9f,
                                                                    4.67f),
                                                        new Vector3(3.2f,
                                                                    -8.9f,
                                                                    4.7f)));
            Assert.AreEqual(new Vector3(1f,
                                        0f,
                                        -1f),
                            MathTool.CalculateDirection(new Vector3(-5.9f,
                                                                    -2.3f,
                                                                    9874.43f),
                                                        new Vector3(9.2f,
                                                                    -2.3f,
                                                                    -38745.24f)));
            return;
        }
    }
}