using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests;

[TestFixture]
public class StepsInPrimesTests
{
    [Test]
    public static void Test1()
    {
        Assert.AreEqual(new long[] {101, 103}, StepsInPrimes.Step(2, 100, 110));
        Assert.AreEqual(new long[] {103, 107}, StepsInPrimes.Step(4, 100, 110));
        Assert.AreEqual(new long[] {101, 107}, StepsInPrimes.Step(6, 100, 110));
        Assert.AreEqual(new long[] {359, 367}, StepsInPrimes.Step(8, 300, 400));
        Assert.AreEqual(new long[] {307, 317}, StepsInPrimes.Step(10, 300, 400));
        Assert.AreEqual(null, StepsInPrimes.Step(11, 30000, 100000));
    }
}