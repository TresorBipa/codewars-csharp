﻿using System;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests;

[TestFixture]
public class DivideAndConquerTests
{
    [Test]
    public void SampleTest()
    {
        Assert.AreEqual(2, DivideAndConquer.DivCon(new object[] {9, 3, "7", "3"}));
        Assert.AreEqual(14, DivideAndConquer.DivCon(new object[] {"5", "0", 9, 3, 2, 1, "9", 6, 7}));
        Assert.AreEqual(13, DivideAndConquer.DivCon(new object[] {"3", 6, 6, 0, "5", 8, 5, "6", 2, "0"}));
        Assert.AreEqual(11, DivideAndConquer.DivCon(new object[] {"1", "5", "8", 8, 9, 9, 2, "3"}));
        Assert.AreEqual(61, DivideAndConquer.DivCon(new object[] {8, 0, 0, 8, 5, 7, 2, 3, 7, 8, 6, 7}));
        Assert.AreEqual(-6, DivideAndConquer.DivCon(new object[] {"0", "1", "2", "3"}));
        Assert.AreEqual(6, DivideAndConquer.DivCon(new object[] {0, 1, 2, 3}));
        Assert.AreEqual(0, DivideAndConquer.DivCon(new object[] {1, "1"}));
        Assert.AreEqual(-2, DivideAndConquer.DivCon(new object[] {-1, "1"}));
        Assert.AreEqual(2, DivideAndConquer.DivCon(new object[] {1, "-1"}));
        Assert.AreEqual(1, DivideAndConquer.DivCon(new object[] {1}));
        Assert.AreEqual(-1, DivideAndConquer.DivCon(new object[] {"1"}));
        Assert.AreEqual(0, DivideAndConquer.DivCon(new object[] { }));
    }

    private static readonly Random Rand = new();

    [Test]
    public void RandomTest()
    {
        for (var i = 0; i < 100; i++)
        {
            var objArray = RandomObjectArray();

            var s = 0;
            foreach (var o in objArray)
            {
                if (o is int)
                    s += int.Parse(o.ToString()!);
                else
                    s -= int.Parse(o.ToString()!);
            }

            var expected = s;
            var actual = DivideAndConquer.DivCon(objArray);
            var message = FailureMessage(objArray, expected);

            Assert.AreEqual(expected, actual, message);
        }
    }

    private static object[] RandomObjectArray()
    {
        return Enumerable.Range(0, Rand.Next(0, 11))
            .Select(x => Rand.Next(0, 10))
            .Select(x => (object) (Rand.Next(0, 3) == 0 ? x.ToString() : x)).ToArray();
    }

    private static string FailureMessage(object[] objArray, int value)
    {
        var strArray = "";
        foreach (var o in objArray)
        {
            if (o is int)
                strArray += $"{o},";
            else
                strArray += $"\"{o}\",";
        }

        strArray = strArray.TrimEnd(',');
        return $"Should return {value} with objArray=[{strArray}]";
    }
}