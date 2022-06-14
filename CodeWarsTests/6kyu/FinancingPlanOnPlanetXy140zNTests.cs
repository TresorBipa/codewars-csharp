using CodeWars;
using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu;

[TestFixture]
public class FinancingPlanOnPlanetXy140zNTests
{
    [Test]
    public void Test01()
    {
        Assert.AreEqual(105, FinancingPlanOnPlanetXy140ZN.finance(5));
    }

    [Test]
    public void Test02()
    {
        Assert.AreEqual(168, FinancingPlanOnPlanetXy140ZN.finance(6));
    }

    [Test]
    public void Test03()
    {
        Assert.AreEqual(360, FinancingPlanOnPlanetXy140ZN.finance(8));
    }

    [Test]
    public void Test04()
    {
        Assert.AreEqual(2040, FinancingPlanOnPlanetXy140ZN.finance(15));
    }
}