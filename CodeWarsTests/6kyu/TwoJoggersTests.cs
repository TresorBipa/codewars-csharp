using System;
using System.Collections.Generic;
using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu;

[TestFixture]
public class TwoJoggersTests
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData(5, 3).Returns(new Tuple<int, int>(3, 5));
            yield return new TestCaseData(4, 6).Returns(new Tuple<int, int>(3, 2));
            yield return new TestCaseData(5, 5).Returns(new Tuple<int, int>(1, 1));
        }
    }

    [Test, TestCaseSource("testCases")]
    public Tuple<int, int> Test(int x, int y) => TwoJoggers.NbrOfLaps(x, y);
}