using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests;

[TestFixture]
public class ProductOfConsecutiveFibNumbersTests
{
    [Test]
    public void Test1()
    {
        ulong[] r = new ulong[] { 55, 89, 1 };
        Assert.AreEqual(r, ProductOfConsecutiveFibNumbers.productFib(4895));
    }
}