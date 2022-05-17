using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RuleOfDivisibilityBy13Tests
    {
        private static void testing(long actual, long expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Testing Thirt");
            testing(RuleOfDivisibilityBy13.Thirt(8529), 79);
            testing(RuleOfDivisibilityBy13.Thirt(85299258), 31);
            testing(RuleOfDivisibilityBy13.Thirt(5634), 57);
            testing(RuleOfDivisibilityBy13.Thirt(1111111111), 71);
            testing(RuleOfDivisibilityBy13.Thirt(987654321), 30);
        }
    }
}