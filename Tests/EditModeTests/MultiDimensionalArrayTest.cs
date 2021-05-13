using NUnit.Framework;
using System.Collections.Generic;

namespace UnityPlugins {
    namespace Tests {
        public static class MultiDimensionalArrayTest {
            [Test]
            public static void TestTwoDimensionalArray() {
                IList<TwoDimensionalArray<int>> twoDimensionalArrayInt = new List<TwoDimensionalArray<int>>();
                twoDimensionalArrayInt.Add(new TwoDimensionalArray<int> {
                    array = new int[] {
                        1,
                        2,
                        3,
                        4,
                        5
                    }
                });
                twoDimensionalArrayInt.Add(new TwoDimensionalArray<int> {
                    array = new int[] {
                        6,
                        7,
                        8,
                        9,
                        10
                    }
                });

                int i = 0;
                foreach (TwoDimensionalArray<int> twoDimensionalArray in twoDimensionalArrayInt) {
                    foreach (int number in twoDimensionalArray.array) {
                        Assert.AreEqual(++i, number);
                    }
                }
                return;
            }
        }
    }
}