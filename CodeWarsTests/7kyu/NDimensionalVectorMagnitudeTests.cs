using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NDimensionalVectorMagnitudeTests
    {
        [Test]
        public void ZeroVector()
        {
            double[] vector = new[] {0d, 0d};
            Assert.AreEqual(0d, NDimensionalVectorMagnitude.Magnitude(vector), 1e-10);
        }

        [Test]
        public void UnitVector()
        {
            double[] vector = new[] {2d / 3d, 1d / 3d, 2d / 3d};
            Assert.AreEqual(1d, NDimensionalVectorMagnitude.Magnitude(vector), 1e-10);
        }

        [Test]
        public void NegativeValues()
        {
            double[] vector = new[] {-2d, -4d, 4d};
            Assert.AreEqual(6d, NDimensionalVectorMagnitude.Magnitude(vector), 1e-10);
        }
    }
}