using System;
using CodeWars;
using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class Kata1NCycleTests
    {
        private static void dotest(int n, int expected)
        {
            // Console.WriteLine("n: {0}, expected: {1}", n, expected);
            Assert.AreEqual(expected, Kata1NCycle.Running(n));
        }

        [Test]
        public static void fixedtest()
        {
            Console.WriteLine("Fixed Tests");
            dotest(33, 2);
            dotest(18118, -1);
            dotest(69, 22);
            dotest(197, 98);
            dotest(65, -1);
        }
    }
}