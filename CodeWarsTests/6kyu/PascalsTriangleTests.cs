using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests;

[TestFixture]
public class PascalsTriangleTests
{
    [Test]
    public void Level1()
    {
        CollectionAssert.AreEqual(
            new List<int> {1},
            KataPascalsTriangle.PascalsTriangle(1));
    }

    [Test]
    public void Level2()
    {
        CollectionAssert.AreEqual(
            new List<int> {1, 1, 1},
            KataPascalsTriangle.PascalsTriangle(2));
    }

    [Test]
    public void Level4()
    {
        CollectionAssert.AreEqual(
            new List<int> {1, 1, 1, 1, 2, 1, 1, 3, 3, 1},
            KataPascalsTriangle.PascalsTriangle(4));
    }
}