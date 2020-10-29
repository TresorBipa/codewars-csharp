using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class OfficeIIBoredomScoreTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("kill me now",
                OfficeIIBoredomScore.Boredom(new Dictionary<string, string>()
                {
                    {"Tim", "accounts"}, {"Jim", "trading"}, {"Sandy", "regulation"}, {"Andy", "accounts"},
                    {"Katie", "finance"}, {"Laura", "IS"}
                }));
            Assert.AreEqual("i can handle this",
                OfficeIIBoredomScore.Boredom(new Dictionary<string, string>()
                {
                    {"Jim", "pissing about"}, {"Tim", "regulation"}, {"Andy", "IS"}, {"Laura", "pissing about"},
                    {"Alex", "canteen"}, {"John", "canteen"}
                }));
            Assert.AreEqual("party time!!",
                OfficeIIBoredomScore.Boredom(new Dictionary<string, string>()
                {
                    {"Andy", "pissing about"}, {"Tim", "accounts"}, {"Smith", "pissing about"},
                    {"Randy", "pissing about"}, {"Sandy", "IS"}, {"Laura", "pissing about"}
                }));
        }
    }
}