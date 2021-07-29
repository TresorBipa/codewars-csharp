using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GravityFlipTests
    {
        [Test]
        public void Sample()
        {
            Assert.AreEqual(new int[] {1, 2, 2, 3}, GravityFlip.Flip('R', new int[] {3, 2, 1, 2}));
            Assert.AreEqual(new int[] {5, 5, 4, 3, 1}, GravityFlip.Flip('L', new int[] {1, 4, 5, 3, 5}));
        }
    }
}