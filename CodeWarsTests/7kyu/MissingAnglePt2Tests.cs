using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MissingAnglePt2Tests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(31.8, MissingAnglePt2.missingAngle(4, 6.9, 4.2));
            Assert.AreEqual(43.7, MissingAnglePt2.missingAngle(76, 105, 53.3));
            Assert.AreEqual(57.1, MissingAnglePt2.missingAngle(6, 7, 5));
            Assert.AreEqual(23.8, MissingAnglePt2.missingAngle(6, 11, 14.1));
        }
    }
}