using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class PureOddDigitsPrimesTests
    {
        private static void testing(long[] actual, long[] expected)
        {
            Assert.AreEqual(expected, actual);
        }

        private static void tests(long[] list1, long[][] results)
        {
            for (int i = 0; i < list1.Length; i++)
                testing(PureOddDigitsPrimes.OnlyOddDigPrimes(list1[i]), results[i]);
            return;
        }

        [Test]
        public static void test1()
        {
            // Console.WriteLine("Basic Tests OnlyOddDigPrimes");
            long[] l = new long[] {20, 40, 55, 60, 100};
            long[][] r = new long[][]
            {
                new long[] {7, 19, 31}, new long[] {9, 37, 53}, new long[] {10, 53, 59},
                new long[] {11, 59, 71}, new long[] {15, 97, 113}
            };
            tests(l, r);
        }
    }
}