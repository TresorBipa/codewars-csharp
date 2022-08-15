using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests;

[TestFixture]
public class MissingAngleTests
{
    [Test]
    public void ExampleTests()
    {
        Assert.AreEqual(37, MissingAngle.missingAngle(0, 400, 300));
        Assert.AreEqual(37, MissingAngle.missingAngle(5, 4, 0));
        Assert.AreEqual(37, MissingAngle.missingAngle(5, 4, 0));
        Assert.AreEqual(39, MissingAngle.missingAngle(8, 0, 5));
        Assert.AreEqual(39, MissingAngle.missingAngle(8, 0, 5));
        Assert.AreEqual(47, MissingAngle.missingAngle(16.7, 0, 12.3));
        Assert.AreEqual(44, MissingAngle.missingAngle(7, 5, 0));
    }
}