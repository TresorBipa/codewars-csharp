using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu;

[TestFixture]
public class Basics01ConvertAnyNumberTests
{
    [Test]
    public void smile67KataTest_withoutRandom1()
    {
        Assert.AreEqual("3/4", new Basics01ConvertAnyNumber().toFraction(0.75));
    }

    [Test]
    public void smile67KataTest_withoutRandom2()
    {
        Assert.AreEqual("-1/3", new Basics01ConvertAnyNumber().toFraction(-0.333333333333333));
    }

    [Test]
    public void smile67KataTest_withoutRandom3()
    {
        Assert.AreEqual("3", new Basics01ConvertAnyNumber().toFraction(3));
    }

    [Test]
    public void smile67KataTest_withoutRandom4()
    {
        Assert.AreEqual("5/6", new Basics01ConvertAnyNumber().toFraction(0.833333333333333));
    }

    [Test]
    public void smile67KataTest_withoutRandom5()
    {
        Assert.AreEqual("0", new Basics01ConvertAnyNumber().toFraction(0));
    }
}