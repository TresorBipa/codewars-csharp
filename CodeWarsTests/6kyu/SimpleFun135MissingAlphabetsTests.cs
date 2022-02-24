using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun135MissingAlphabetsTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun135MissingAlphabets();
            Assert.AreEqual("z", kata.MissingAlphabets("abcdefghijklmnopqrstuvwxy"));
            Assert.AreEqual("", kata.MissingAlphabets("abcdefghijklmnopqrstuvwxyz"));
            Assert.AreEqual("zz", kata.MissingAlphabets("aabbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxyy"));
            Assert.AreEqual("ayzz", kata.MissingAlphabets("abbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxy"));
            Assert.AreEqual("bfghijklmnpqtuvxyz", kata.MissingAlphabets("codewars"));
        }
    }
}