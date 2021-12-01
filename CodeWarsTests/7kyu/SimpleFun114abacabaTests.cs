using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun114abacabaTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun114abacaba();

            Assert.AreEqual('a', kata.abacaba(1));

            Assert.AreEqual('b', kata.abacaba(2));

            Assert.AreEqual('a', kata.abacaba(3));

            Assert.AreEqual('c', kata.abacaba(4));

            Assert.AreEqual('a', kata.abacaba(5));

            Assert.AreEqual('b', kata.abacaba(6));

            Assert.AreEqual('a', kata.abacaba(7));

            Assert.AreEqual('d', kata.abacaba(8));

            Assert.AreEqual('c', kata.abacaba(12));

            Assert.AreEqual('e', kata.abacaba(16));
        }
    }
}