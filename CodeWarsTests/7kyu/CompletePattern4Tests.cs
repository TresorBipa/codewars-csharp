using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CompletePattern4Tests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("1", CompletePattern4.Pattern(1));
            Assert.AreEqual("12\n2", CompletePattern4.Pattern(2));
            Assert.AreEqual("12345\n2345\n345\n45\n5", CompletePattern4.Pattern(5));
        }
    }
}