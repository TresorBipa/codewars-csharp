using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests;

[TestFixture]
public class LineSafariPointDistanceFromLineTests
{
    [Test]
    public void Example()
    {
        (int, int) a, b, c;

        a = (10, 10);
        c = (20, 25);
        b = (30, 10);
        Assert.AreEqual(15d, LineSafariPointDistanceFromLine.DistanceFromLine(a, b, c), 0.001);

        a = (10, 10);
        c = (40, 40);
        b = (70, 70);
        Assert.AreEqual(0d, LineSafariPointDistanceFromLine.DistanceFromLine(a, b, c), 0.001);
    }
}