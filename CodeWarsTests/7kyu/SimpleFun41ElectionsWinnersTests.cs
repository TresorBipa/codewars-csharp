using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun41ElectionsWinnersTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun41ElectionsWinners();
            Assert.AreEqual(2, kata.ElectionsWinners(new int[] {2, 3, 5, 2}, 3));
            Assert.AreEqual(0, kata.ElectionsWinners(new int[] {1, 3, 3, 1, 1}, 0));
            Assert.AreEqual(1, kata.ElectionsWinners(new int[] {5, 1, 3, 4, 1}, 0));
            Assert.AreEqual(4, kata.ElectionsWinners(new int[] {1, 1, 1, 1}, 1));
            Assert.AreEqual(0, kata.ElectionsWinners(new int[] {1, 1, 1, 1}, 0));
            Assert.AreEqual(2, kata.ElectionsWinners(new int[] {3, 1, 1, 3, 1}, 2));
        }
    }
}