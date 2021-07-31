using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataHalfLifeTests
    {
        private static double epsilon = 1e-9;

        [Test]
        public void SampleTest()
        {
            Assert.That(KataHalfLife.HalfLife(10, 5, 1), Is.EqualTo(1).Within(epsilon));
            Assert.That(KataHalfLife.HalfLife(8, 4, 2), Is.EqualTo(2).Within(epsilon));
            Assert.That(KataHalfLife.HalfLife(12, 3, 2), Is.EqualTo(1).Within(epsilon));
        }
    }
}