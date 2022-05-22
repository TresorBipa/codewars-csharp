using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun79DeleteDigitTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun79DeleteDigit();
            Assert.AreEqual(52, kata.DeleteDigit(152));
            Assert.AreEqual(101, kata.DeleteDigit(1001));
            Assert.AreEqual(1, kata.DeleteDigit(10));
        }
    }
}