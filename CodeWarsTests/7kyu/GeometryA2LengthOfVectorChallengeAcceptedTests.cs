using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GeometryA2LengthOfVectorChallengeAcceptedTests
    {
        private static double epsilon = 1e-7;

        [Test]
        public void ExampleTest()
        {
            Assert.That(
                GeometryA2LengthOfVectorChallengeAccepted.VectorLength(
                    new GeometryA2LengthOfVectorChallengeAccepted.Vector2(
                        new GeometryA2LengthOfVectorChallengeAccepted.Point2(0, 1),
                        new GeometryA2LengthOfVectorChallengeAccepted.Point2(0, 0))),
                Is.EqualTo(1).Within(epsilon));

            Assert.That(
                GeometryA2LengthOfVectorChallengeAccepted.VectorLength(
                    new GeometryA2LengthOfVectorChallengeAccepted.Vector2(
                        new GeometryA2LengthOfVectorChallengeAccepted.Point2(0, 3),
                        new GeometryA2LengthOfVectorChallengeAccepted.Point2(4, 0))),
                Is.EqualTo(5).Within(epsilon));

            // Assert.That(
            //     GeometryA2LengthOfVectorChallengeAccepted.VectorLength(
            //         new GeometryA2LengthOfVectorChallengeAccepted(new GeometryA2LengthOfVectorChallengeAccepted.Point2(1, -1), new GeometryA2LengthOfVectorChallengeAccepted.Point2(1, -1))),
            //     Is.EqualTo(0).Within(epsilon));
        }
    }
}