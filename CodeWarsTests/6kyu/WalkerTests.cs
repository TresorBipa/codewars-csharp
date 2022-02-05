using System;
using System.Linq;
using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class WalkerTests
    {
        private static void dotest(int a, int b, int c, int alpha, int beta, int gamma, string expect)
        {
            int[] d = Walker.Solve(a, b, c, alpha, beta, gamma);
            String actual = String.Join(", ", d.Select(p => p.ToString()).ToArray());
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Basic Tests");
            dotest(12, 20, 18, 45, 30, 60, "15, 135, 49, 18");
            dotest(15, 15, 19, 50, 29, 55, "12, 133, 18, 44");
            dotest(14, 25, 17, 41, 35, 59, "20, 129, 41, 57");
        }
    }
}