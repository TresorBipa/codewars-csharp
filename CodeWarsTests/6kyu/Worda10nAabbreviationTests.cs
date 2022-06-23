using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class Worda10nAabbreviationTests
    {
        [Test]
        public void TestInternationalization()
        {
            Assert.AreEqual("i18n", Worda10nAabbreviation.Abbreviate("internationalization"));
        }

        [Test]
        public void TestShortSentance()
        {
            Assert.AreEqual("my. dog, isn't f5g v2y w2l.",
                Worda10nAabbreviation.Abbreviate("my. dog, isn't feeling very well."));
        }
    }
}