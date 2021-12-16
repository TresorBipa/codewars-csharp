using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun175SameEncryptionTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun175SameEncryption();
            Assert.AreEqual(true, kata.SameEncryption("abc", "abc"));
            Assert.AreEqual(false, kata.SameEncryption("abc", "abd"));
            Assert.AreEqual(true, kata.SameEncryption("fKhjuytrdfcdc", "flJc"));
            Assert.AreEqual(false, kata.SameEncryption("OKhjuytrdfcdc", "OijK"));
        }
    }
}