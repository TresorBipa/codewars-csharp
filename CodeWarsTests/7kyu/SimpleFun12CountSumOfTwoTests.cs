using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun12CountSumOfTwoTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun12CountSumOfTwo();

            Assert.AreEqual(2, kata.CountSumOfTwoRepresentations(6, 2, 4), "");

            Assert.AreEqual(1, kata.CountSumOfTwoRepresentations(6, 3, 3), "");

            Assert.AreEqual(0, kata.CountSumOfTwoRepresentations(10, 9, 11), "");

            Assert.AreEqual(5, kata.CountSumOfTwoRepresentations(24, 8, 16), "");

            Assert.AreEqual(1, kata.CountSumOfTwoRepresentations(24, 12, 12), "");

            Assert.AreEqual(12, kata.CountSumOfTwoRepresentations(93, 24, 58), "");
        }
    }
}