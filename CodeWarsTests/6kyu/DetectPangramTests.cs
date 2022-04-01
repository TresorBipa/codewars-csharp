using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DetectPangramTests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(true, DetectPangram.IsPangram("The quick brown fox jumps over the lazy dog."));
        }
    }
}