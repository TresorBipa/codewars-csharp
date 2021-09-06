using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MonkeysMATH01Tests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(0, MonkeysMATH01.CountZero(""), "There are no '0's.");
            Assert.AreEqual(1, MonkeysMATH01.CountZero("0"), "There is 1 '0'.");
            Assert.AreEqual(5, MonkeysMATH01.CountZero("1234567890"), "There are 5 '0's.");
            Assert.AreEqual(8, MonkeysMATH01.CountZero("abcdefghijklmnopqrstuvwxyz"), "There are 8 '0's.");
        }
    }
}