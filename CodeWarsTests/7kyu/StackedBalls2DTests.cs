using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class StackedBalls2DTests
    {
        private static double EPSILON = 0.001;

        [Test]
        public void Test1()
        {
            Assert.AreEqual(1.0, StackedBalls2D.StackHeight2d(1), EPSILON);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1.866, StackedBalls2D.StackHeight2d(2), EPSILON);
        }
    }
}