using NUnit.Framework;
using System.Collections.Generic;
using UnityPlugins.MultidimensionalArray;

namespace UnityPlugins.Tests.EditMode {
    internal static class MultiDimensionalArrayTest {
        [Test]
        public static void TestTwoDimensionalArray() {
            IList<TwoDimensionalArray<int>> twoDimensionalArrayInt = new List<TwoDimensionalArray<int>>();
            twoDimensionalArrayInt.Add(new TwoDimensionalArray<int> {
                Array = new[] {
                    1,
                    2,
                    3,
                    4,
                    5
                }
            });
            twoDimensionalArrayInt.Add(new TwoDimensionalArray<int> {
                Array = new[] {
                    6,
                    7,
                    8,
                    9,
                    10
                }
            });

            int i = 0;
            foreach (TwoDimensionalArray<int> twoDimensionalArray in twoDimensionalArrayInt) {
                foreach (int number in twoDimensionalArray.Array) {
                    Assert.AreEqual(++i, number);
                }
            }
            return;
        }
    }
}