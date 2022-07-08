using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataFriendsTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(0, KataFriends.Friends(0));
            Assert.AreEqual(0, KataFriends.Friends(1));
            Assert.AreEqual(0, KataFriends.Friends(2));
        }
    }
}