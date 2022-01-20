using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun34NumbersGroupingTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun34NumbersGrouping();

            Assert.AreEqual(11, kata.NumbersGrouping(new int[] {20000, 239, 10001, 999999, 10000, 20566, 29999}));

            Assert.AreEqual(23,
                kata.NumbersGrouping(new int[]
                    {10000, 20000, 30000, 40000, 50000, 60000, 10000, 120000, 150000, 200000, 300000, 1000000}));

            Assert.AreEqual(2, kata.NumbersGrouping(new int[] {10000}));

            Assert.AreEqual(3, kata.NumbersGrouping(new int[] {10000, 1}));
        }
    }
}