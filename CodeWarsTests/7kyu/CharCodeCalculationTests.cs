using System;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests;

[TestFixture]
public class CharCodeCalculationTests
{
    [Test]
    public void SampleTest()
    {
        Assert.AreEqual(0, CharCodeCalculation.Calc(""));
        Assert.AreEqual(6, CharCodeCalculation.Calc("abc"));
        Assert.AreEqual(6, CharCodeCalculation.Calc("ABC"));
        Assert.AreEqual(6, CharCodeCalculation.Calc("abcdef"));
        Assert.AreEqual(6, CharCodeCalculation.Calc("ifkhchlhfd"));
        Assert.AreEqual(6, CharCodeCalculation.Calc("jfmgklf8hglbe"));
        Assert.AreEqual(12, CharCodeCalculation.Calc("jaam"));
        Assert.AreEqual(18, CharCodeCalculation.Calc("AFHJD"));
        Assert.AreEqual(18, CharCodeCalculation.Calc("CodeWars"));
        Assert.AreEqual(24, CharCodeCalculation.Calc("FVJFVDF"));
        Assert.AreEqual(24, CharCodeCalculation.Calc("AOUCUAOF"));
        Assert.AreEqual(30, CharCodeCalculation.Calc("aaaaaddddr"));
        Assert.AreEqual(36, CharCodeCalculation.Calc("XLdNDcAbUkMnkV"));
        Assert.AreEqual(42, CharCodeCalculation.Calc("cSuLifxDQkOiypJsxOJSE"));
        Assert.AreEqual(48, CharCodeCalculation.Calc("ZHAUnSGoIbgPSezhjePIbHFrHUOv"));
        Assert.AreEqual(54, CharCodeCalculation.Calc("VFhSMbZETZVHxYiiYsBMrWuecDN"));
        Assert.AreEqual(60, CharCodeCalculation.Calc("sphPoGbicTCLbiuUcwFMEGaFmy"));
        Assert.AreEqual(72, CharCodeCalculation.Calc("oXoQKiCflHIHFyGizCYCuaHhX"));
        Assert.AreEqual(84, CharCodeCalculation.Calc("sUuPmNnnJOOCAGOuyzmcHQGJhXHYgZLY"));
    }

    private static readonly Random Rand = new();

    [Test]
    public void RandomTest()
    {
        for (var i = 0; i < 100; i++)
        {
            var s = RandomStr();

            var total1 = string.Concat(s.Select(x => (int) x));
            var total2 = total1.Replace("7", "1");
            var expected = total1.Sum(x => int.Parse(x.ToString())) - total2.Sum(x => int.Parse(x.ToString()));

            var message = FailureMessage(s, expected);
            var actual = CharCodeCalculation.Calc(s);

            Assert.AreEqual(expected, actual, message);
        }
    }

    private static string RandomStr()
    {
        const string chars = "abcdefghijklmnopqrsyuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var result = string.Concat(Enumerable.Repeat(chars, Rand.Next(1, chars.Length))
            .Select(s => s[Rand.Next(s.Length)]).Take(Rand.Next(0, 8)));

        return result;
    }

    private static string FailureMessage(string s, int value)
    {
        return $"Should return {value} with s=\"{s}\"";
    }
}