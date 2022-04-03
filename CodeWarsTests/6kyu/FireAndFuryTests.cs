using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataFireAndFuryTests
    {
        [Test]
        public void Ex1()
        {
            Assert.AreEqual("I am furious. You and you are fired!", KataFireAndFury.FireAndFury("FURYYYFIREYYFIRE"));
        }

        [Test]
        public void Ex2()
        {
            Assert.AreEqual("You are fired! I am really furious. You are fired!",
                KataFireAndFury.FireAndFury("FIREYYFURYYFURYYFURRYFIRE"));
        }

        [Test]
        public void Ex3()
        {
            Assert.AreEqual("Fake tweet.", KataFireAndFury.FireAndFury("FYRYFIRUFIRUFURE"));
        }
    }
}