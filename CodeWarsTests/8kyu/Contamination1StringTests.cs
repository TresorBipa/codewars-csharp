﻿using System;
using CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWarsTests._8kyu;

[TestFixture]
public class Contamination1StringTests
{
    [Test]
    public void SampleTest()
    {
        Assert.AreEqual("zzz", Contamination1String.Contamination("abc", "z"));
        Assert.AreEqual("", Contamination1String.Contamination("", "z"));
        Assert.AreEqual("", Contamination1String.Contamination("abc", String.Empty));
        Assert.AreEqual("&&&&&&&&", Contamination1String.Contamination("_3ebzgh4", "&"));
        Assert.AreEqual("      ", Contamination1String.Contamination("//case", " "));
    }
}