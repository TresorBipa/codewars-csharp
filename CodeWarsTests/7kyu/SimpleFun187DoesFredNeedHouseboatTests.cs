using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun187DoesFredNeedHouseboatTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun187DoesFredNeedHouseboat();
            Assert.AreEqual(1, kata.DoesFredNeedHouseboat(1, 1));
            Assert.AreEqual(20, kata.DoesFredNeedHouseboat(25, 0));
        }
    }
}