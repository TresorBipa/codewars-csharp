using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class XbonacciTests
    {
        private Xbonacci variabonacci;

        [SetUp]
        public void SetUp()
        {
            variabonacci = new Xbonacci();
        }

        [TearDown]
        public void TearDown()
        {
            variabonacci = null;
        }

        [Test]
        public void Tests()
        {
            Assert.AreEqual(new double[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 },
                variabonacci.xbonacci(new double[] { 0, 1 }, 10));
            Assert.AreEqual(new double[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 },
                variabonacci.xbonacci(new double[] { 1, 1 }, 10));
            Assert.AreEqual(new double[] { 0, 0, 0, 0, 1, 1, 2, 4, 8, 16 },
                variabonacci.xbonacci(new double[] { 0, 0, 0, 0, 1 }, 10));
            Assert.AreEqual(new double[] { 1, 0, 0, 0, 0, 0, 1, 2, 3, 6 },
                variabonacci.xbonacci(new double[] { 1, 0, 0, 0, 0, 0, 1 }, 10));
        }
    }
}