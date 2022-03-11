using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MaximumSubarraySumTests
    {
        public static Random randNum = new Random();

        public static int MaxSequence(int[] arr)
        {
            int m = 0;
            int a = 0;
            int s = 0;
            foreach (int e in arr)
            {
                s += e;
                m = s > m ? m : s;
                a = a > s - m ? a : s - m;
            }

            return a;
        }

        [Test]
        public void Test0()
        {
            Assert.AreEqual(0, MaximumSubarraySum.MaxSequence(new int[0]));
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(6, MaximumSubarraySum.MaxSequence(new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4}));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(155,
                MaximumSubarraySum.MaxSequence(new int[]
                    {7, 4, 11, -11, 39, 36, 10, -6, 37, -10, -32, 44, -26, -34, 43, 43}));
        }

        private int[] GetRandomArray()
        {
            var arr = new int[50];
            for (int i = 0; i < 50; i++)
            {
                arr[i] = randNum.Next(-40, 40);
            }

            return arr;
        }

        [Test]
        public void RandomTests()
        {
            for (int i = 0; i < 50; ++i)
            {
                var arr = GetRandomArray();
                Assert.AreEqual(MaxSequence(arr), MaximumSubarraySum.MaxSequence(arr));
            }
        }
    }
}