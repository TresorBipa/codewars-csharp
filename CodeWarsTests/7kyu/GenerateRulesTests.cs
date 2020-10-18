using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataGenerateRulesTests
    {
        public static string MakeTcpRule(uint port) => $"iptables -I INPUT -p tcp --dport {port} -j ACCEPT ;";

        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("iptables -I INPUT -p tcp --dport 22 -j ACCEPT ;",
                KataGenerateRules.GenerateRules(MakeTcpRule, new List<uint> { 22 }));
        }
    }
}