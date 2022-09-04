using System.Collections.Generic;
using CodeWars._5kyu;
using NUnit.Framework;

namespace CodeWarsTests._5kyu;

[TestFixture]
public class BestTravelTests
{
    [Test]
    public void Test1()
    {
        List<int> ts = new List<int> { 50, 55, 56, 57, 58 };
        int? n = BestTravel.chooseBestSum(163, 3, ts);
        Assert.AreEqual(163, n);

        ts = new List<int> { 50 };
        n = BestTravel.chooseBestSum(163, 3, ts);
        Assert.AreEqual(null, n);

        ts = new List<int> { 91, 74, 73, 85, 73, 81, 87 };
        n = BestTravel.chooseBestSum(230, 3, ts);
        Assert.AreEqual(228, n);
    }
}