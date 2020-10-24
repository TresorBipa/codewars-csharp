using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NumberClimberTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(string.Join(",", new int[] {1}), string.Join(",", NumberClimber.Climb(1)));
            Assert.AreEqual(string.Join(",", new int[] {1, 2, 5, 10}), string.Join(",", NumberClimber.Climb(10)));
            Assert.AreEqual(string.Join(",", new int[] {1, 3, 6, 13}), string.Join(",", NumberClimber.Climb(13)));
        }
    }
}