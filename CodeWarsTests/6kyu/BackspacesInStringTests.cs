using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BackspacesInStringTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("ac", BackspacesInString.CleanString("abc#d##c"));
            Assert.AreEqual("", BackspacesInString.CleanString("abc####d##c#"));
        }
    }
}