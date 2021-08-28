using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class LookingForBenefactorTests
    {
        private static void testing(long actual, long expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Basic Tests");
            double[] a = new double[] {14, 30, 5, 7, 9, 11, 15};
            testing(LookingForBenefactor.NewAvg(a, 100), 709);
            a = new double[] {14.0, 30.0, 5.0, 7.0, 9.0, 11.0, 16.0};
            testing(LookingForBenefactor.NewAvg(a, 90), 628);
        }

        [Test]
        public static void ErrorTests()
        {
            Console.WriteLine("Error Tests");
            double[] a = new double[] {14, 30, 5, 7, 9, 11, 15};
            Assert.Throws<ArgumentException>(() => LookingForBenefactor.NewAvg(a, 2));
        }
    }
}