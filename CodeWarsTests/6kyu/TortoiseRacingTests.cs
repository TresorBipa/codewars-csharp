using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TortoiseRacingTests
    {
        [Test]
        public void Test1()
        {
            Console.WriteLine("****** Basic Tests");
            Assert.AreEqual(new int[] {0, 32, 18}, TortoiseRacing.Race(720, 850, 70));
            Assert.AreEqual(new int[] {3, 21, 49}, TortoiseRacing.Race(80, 91, 37));
            Assert.AreEqual(new int[] {2, 0, 0}, TortoiseRacing.Race(80, 100, 40));
        }
    }
}