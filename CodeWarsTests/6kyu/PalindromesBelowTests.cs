using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class PalindromesBelowTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(new int[] {1, 3}, 4.PalindromeBelow(2));
            Assert.AreEqual(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 11}, 15.PalindromeBelow(10));
        }
    }
}