using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BouncingBallsTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(3, BouncingBalls.bouncingBall(3.0, 0.66, 1.5));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(15, BouncingBalls.bouncingBall(30.0, 0.66, 1.5));
        }
    }
}