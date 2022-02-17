using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun68PalindromeRearrangingTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun68PalindromeRearranging();

            Assert.AreEqual(true, kata.PalindromeRearranging("aabb"));

            Assert.AreEqual(false, kata.PalindromeRearranging("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaabc"));

            Assert.AreEqual(true, kata.PalindromeRearranging("abbcabb"));

            Assert.AreEqual(true, kata.PalindromeRearranging("zyyzzzzz"));

            Assert.AreEqual(false, kata.PalindromeRearranging("aaabbb"));
        }
    }
}