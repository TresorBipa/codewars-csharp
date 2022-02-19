using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun69AreEquallyStrongTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun69AreEquallyStrong();

            Assert.AreEqual(true, kata.AreEquallyStrong(10, 15, 15, 10));

            Assert.AreEqual(true, kata.AreEquallyStrong(15, 10, 15, 10));

            Assert.AreEqual(true, kata.AreEquallyStrong(10, 10, 10, 10));

            Assert.AreEqual(false, kata.AreEquallyStrong(15, 10, 15, 9));

            Assert.AreEqual(true, kata.AreEquallyStrong(10, 5, 5, 10));

            Assert.AreEqual(false, kata.AreEquallyStrong(1, 10, 10, 0));

            Assert.AreEqual(false, kata.AreEquallyStrong(10, 5, 11, 4));
        }
    }
}