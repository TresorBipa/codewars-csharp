using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ConvertIntegerToBinaryTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("10", ConvertIntegerToBinary.ToBinary(2));
            Assert.AreEqual("11", ConvertIntegerToBinary.ToBinary(3));
            Assert.AreEqual("100", ConvertIntegerToBinary.ToBinary(4));
            Assert.AreEqual("101", ConvertIntegerToBinary.ToBinary(5));
        }
    }
}