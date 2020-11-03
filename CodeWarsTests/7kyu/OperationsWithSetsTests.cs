using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class OperationsWithSetsTests
    {
        public void BasicTests()
        {
            var arr1 = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
            var arr2 = new int[] {2, 4, 6, 8, 10, 12, 14};
            Assert.AreEqual(new int[] {4, 8, 5, 3}, OperationsWithSets.Process2Arrays(arr1, arr2));

            arr1 = new int[] {33, 2, 3, 37, 38, 40, 12, 10, 43, 44, 47, 49, 8, 19, 22, 24, 26, 28, 29, 30};
            arr2 = new int[] {1, 34, 17, 7, 9, 10, 43, 49, 22, 27, 28};
            Assert.AreEqual(new int[] {5, 21, 15, 6}, OperationsWithSets.Process2Arrays(arr1, arr2));

            arr1 = new int[] {32, 34, 3, 4, 39, 10, 43, 13, 11, 18, 21, 22, 7, 25, 26, 36};
            arr2 = new int[] {32, 5, 38, 8, 41, 42, 12, 48, 40, 21, 22, 26, 10, 30};
            Assert.AreEqual(new int[] {5, 20, 11, 9}, OperationsWithSets.Process2Arrays(arr1, arr2));

            arr1 = new int[] {0, 33, 37, 6, 10, 44, 13, 47, 16, 18, 22, 25};
            arr2 = new int[] {1, 38, 48, 8, 41, 7, 12, 47, 16, 40, 20, 23, 25};
            Assert.AreEqual(new int[] {3, 19, 9, 10}, OperationsWithSets.Process2Arrays(arr1, arr2));

            arr1 = new int[] {0, 19, 34, 35, 5, 7, 45, 13, 3, 20, 26, 29, 30};
            arr2 = new int[] {33, 4, 38, 1, 8, 13, 47, 23, 28, 30, 31};
            Assert.AreEqual(new int[] {2, 20, 11, 9}, OperationsWithSets.Process2Arrays(arr1, arr2));

            arr1 = new int[] {0, 35, 17, 6, 7, 10, 11, 46, 47, 16, 49, 20, 14, 23, 25, 26, 29};
            arr2 = new int[] {0, 6, 17, 42, 43, 47, 16, 49, 50, 21, 28, 30};
            Assert.AreEqual(new int[] {6, 17, 11, 6}, OperationsWithSets.Process2Arrays(arr1, arr2));
        }
    }
}