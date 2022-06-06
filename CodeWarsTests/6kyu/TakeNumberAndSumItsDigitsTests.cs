using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TakeNumberAndSumItsDigitsTests
    {
        private static string Array2String(long[] list)
        {
            return "[" + string.Join(", ", list) + "]";
        }

        private static void testing(long a, long b, long[] res)
        {
            Assert.AreEqual(Array2String(res),
                Array2String(TakeNumberAndSumItsDigits.SumDigPow(a, b)));
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Basic Tests SumDigPow");
            testing(1, 10, new long[] {1, 2, 3, 4, 5, 6, 7, 8, 9});
            testing(1, 100, new long[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 89});
            testing(10, 100, new long[] {89});
            testing(90, 100, new long[] { });
            testing(90, 150, new long[] {135});
            testing(50, 150, new long[] {89, 135});
            testing(10, 150, new long[] {89, 135});
        }
    }
}