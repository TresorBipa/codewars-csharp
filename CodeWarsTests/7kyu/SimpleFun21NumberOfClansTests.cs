using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun21NumberOfClansTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun21NumberOfClans();
            Assert.AreEqual(4, kata.NumberOfClans(new int[] {2, 3}, 6));
            Assert.AreEqual(5, kata.NumberOfClans(new int[] {2, 3, 4}, 6));
            Assert.AreEqual(2, kata.NumberOfClans(new int[] {1, 3}, 10));
            Assert.AreEqual(5, kata.NumberOfClans(new int[] {6, 2, 2, 8, 9, 2, 2, 2, 2}, 10));
        }
    }
}