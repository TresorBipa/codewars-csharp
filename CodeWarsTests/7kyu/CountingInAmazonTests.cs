using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CountingInAmazonTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("anane", CountingInAmazon.CountArara(1));
            Assert.AreEqual("adak anane", CountingInAmazon.CountArara(3));
            Assert.AreEqual("adak adak adak adak", CountingInAmazon.CountArara(8));
        }
    }
}