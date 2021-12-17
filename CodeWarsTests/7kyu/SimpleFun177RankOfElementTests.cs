using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun177RankOfElementTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun177RankOfElement();

            Assert.AreEqual(3, kata.RankOfElement(new int[] {2, 1, 2, 1, 2}, 2));

            Assert.AreEqual(2, kata.RankOfElement(new int[] {2, 1, 2, 2, 2}, 2));

            Assert.AreEqual(2, kata.RankOfElement(new int[] {2, 2, 2, 2, 2}, 2));

            Assert.AreEqual(2, kata.RankOfElement(new int[] {3, 2, 3, 4, 1}, 0));

            Assert.AreEqual(1, kata.RankOfElement(new int[] {3, 2, 3, 4, 1}, 1));

            Assert.AreEqual(3, kata.RankOfElement(new int[] {3, 2, 3, 4, 1}, 2));
        }
    }
}