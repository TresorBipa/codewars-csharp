using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun32CreateAnagramTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun32CreateAnagram();

            Assert.AreEqual(1, kata.CreateAnagram("AABAA", "BBAAA"));

            Assert.AreEqual(4, kata.CreateAnagram("OVGHK", "RPGUC"));

            Assert.AreEqual(1,
                kata.CreateAnagram("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAB", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAC"));
        }
    }
}