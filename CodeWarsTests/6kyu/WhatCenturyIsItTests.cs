using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu;

[TestFixture]
public class WhatCenturyIsItTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual("20th", WhatCenturyIsIt.WhatCentury("1999"),
            "With input '1999' solution produced wrong output.");
        Assert.AreEqual("21st", WhatCenturyIsIt.WhatCentury("2011"),
            "With input '2011' solution produced wrong output.");
        Assert.AreEqual("22nd", WhatCenturyIsIt.WhatCentury("2154"),
            "With input '2154' solution produced wrong output.");
        Assert.AreEqual("23rd", WhatCenturyIsIt.WhatCentury("2259"),
            "With input '2259' solution produced wrong output.");
        Assert.AreEqual("13th", WhatCenturyIsIt.WhatCentury("1234"),
            "With input '1234' solution produced wrong output.");
        Assert.AreEqual("11th", WhatCenturyIsIt.WhatCentury("1023"),
            "With input '1023' solution produced wrong output.");
        Assert.AreEqual("20th", WhatCenturyIsIt.WhatCentury("2000"),
            "With input '2000' solution produced wrong output.");
    }
}