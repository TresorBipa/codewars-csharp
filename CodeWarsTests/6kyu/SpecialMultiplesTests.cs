using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class SpecialMultiplesTests
    {
        private static void testing(long actual, long expected)
        {
            Assert.AreEqual(expected, actual);
        }

        private static void tests(long[][] list1, long[] results)
        {
            for (int i = 0; i < list1.Length; i++)
                testing(SpecialMultiples.CountSpecMult(list1[i][0], list1[i][1]), results[i]);
            return;
        }

        [Test]
        public static void test1()
        {
            // Console.WriteLine("Basic Tests CountSpecMult");
            long[][] l = new long[][]
            {
                new long[] {2, 100}, new long[] {2, 1000}, new long[] {2, 10000}, new long[] {2, 100000},
                new long[] {3, 100},
                new long[] {3, 1000}, new long[] {3, 10000}, new long[] {3, 100000}, new long[] {4, 100},
                new long[] {4, 1000}, new long[] {4, 10000}, new long[] {4, 100000}
            };
            long[] r = {16, 166, 1666, 16666, 3, 33, 333, 3333, 0, 4, 47, 476};
            tests(l, r);
        }
    }
}