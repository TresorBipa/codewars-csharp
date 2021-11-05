using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ValidateHexadecimalTests
    {
        [Test]
        public void _0_BasicTests()
        {
            var kata = new ValidateHexadecimal();

            Assert.AreEqual(true, kata.IsHex("ff00ff"));
            Assert.AreEqual(true, kata.IsHex("f0f"));
            Assert.AreEqual(false, kata.IsHex("ffg"));
        }
    }
}