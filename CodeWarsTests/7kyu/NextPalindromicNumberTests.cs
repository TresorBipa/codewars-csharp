using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NextPalindromicNumberTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(22, NextPalindromicNumber.NextPal(11));
            Assert.AreEqual(191, NextPalindromicNumber.NextPal(188));
            Assert.AreEqual(202, NextPalindromicNumber.NextPal(191));
            Assert.AreEqual(2552, NextPalindromicNumber.NextPal(2541));
        }
    }
}