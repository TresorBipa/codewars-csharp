using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu;

[TestFixture]
public class PointsInCircleTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(5, PointsInCircle.pointsNumber(1));
        Assert.AreEqual(13, PointsInCircle.pointsNumber(2));
        Assert.AreEqual(29, PointsInCircle.pointsNumber(3));
        Assert.AreEqual(81, PointsInCircle.pointsNumber(5));
        Assert.AreEqual(3141549, PointsInCircle.pointsNumber(1000));
    }
}