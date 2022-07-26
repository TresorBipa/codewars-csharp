using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests;

[TestFixture]
public class NThFibonacciTests
{
    [Test]
    public void Test()
    {
        NThFibonacci fib = new NThFibonacci();
        Assert.AreEqual(0, fib.NthFib(1));
        Assert.AreEqual(1, fib.NthFib(2));
        Assert.AreEqual(1, fib.NthFib(3));
        Assert.AreEqual(2, fib.NthFib(4));
    }
}