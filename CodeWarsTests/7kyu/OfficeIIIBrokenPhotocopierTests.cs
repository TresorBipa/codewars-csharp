using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class OfficeIIIBrokenPhotocopierTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("0", OfficeIIIBrokenPhotocopier.Broken("1"));
            
            Assert.AreEqual("01111111010010000001100110111",
                OfficeIIIBrokenPhotocopier.Broken("10000000101101111110011001000"));
            
            Assert.AreEqual("011101", OfficeIIIBrokenPhotocopier.Broken("100010"));
        }
    }
}