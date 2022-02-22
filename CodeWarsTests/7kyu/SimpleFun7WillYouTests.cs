using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun7WillYouTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun7WillYou();

            Assert.AreEqual(false, kata.WillYou(true, true, true), "");

            Assert.AreEqual(true, kata.WillYou(true, false, true), "");

            Assert.AreEqual(false, kata.WillYou(false, false, false), "");

            Assert.AreEqual(true, kata.WillYou(false, false, true), "");
        }
    }
}