using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu;

[TestFixture]
public class EasyButCrazyCalculatorTests
{
    [Test]
    public void smile67KataTest_withoutRandom1()
    {
        Assert.AreEqual(26, new EasyButCrazyCalculator().crazyCalculate("12+3-17"));
    }

    [Test]
    public void smile67KataTest_withoutRandom2()
    {
        Assert.AreEqual(3.75, new EasyButCrazyCalculator().crazyCalculate("15*4"));
    }

    [Test]
    public void smile67KataTest_withoutRandom3()
    {
        Assert.AreEqual(-19, new EasyButCrazyCalculator().crazyCalculate("34*2+18/2"));
    }

    [Test]
    public void smile67KataTest_withoutRandom4()
    {
        Assert.AreEqual(-3, new EasyButCrazyCalculator().crazyCalculate("12+1+2+3+4+5"));
    }
}