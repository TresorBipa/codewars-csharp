using CodeWars;
using CodeWars._7kyu;
using NUnit.Framework;

namespace CodeWarsTests._7kyu
{
    [TestFixture]
    public class HighestAndLowestTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("42 -9", HighestAndLowest.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("3 1", HighestAndLowest.HighAndLow("1 2 3"));
        }
    }
}