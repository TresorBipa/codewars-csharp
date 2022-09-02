using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests;

[TestFixture]
public class InterlockingBinaryPairsTests
{
    [Test]
    public void SampleTests()
    {
        Object[][] tests =
        {
            new Object[] {true, 9UL, 4UL},
            new Object[] {false, 5UL, 6UL},
            new Object[] {true, 2UL, 5UL},
            new Object[] {false, 7UL, 1UL},
            new Object[] {true, 0UL, 8UL}
        };
        foreach (Object[] test in tests)
        {
            bool expected = (bool) test[0];
            ulong a = (ulong) test[1];
            ulong b = (ulong) test[2];
            bool submitted = InterlockingBinaryPairs.Interlockable(a, b);
            string message = "a = " + a + "\n  b = " + b;
            Assert.AreEqual(expected, submitted, message);
        }
    }
}