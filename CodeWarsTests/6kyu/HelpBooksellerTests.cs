using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HelpBooksellerTests
    {
        [Test]
        public void Test1()
        {
            string[] art = new string[] {"ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600"};
            String[] cd = new String[] {"A", "B"};
            Assert.AreEqual("(A : 200) - (B : 1140)", HelpBookseller.stockSummary(art, cd));
        }

        [Test]
        public void Test2()
        {
            string[] art = new string[] {"BBAR 150", "CDXE 515", "BKWR 250", "BTSQ 890", "DRTY 600"};
            String[] cd = new String[] {"A", "B", "C", "D"};
            Assert.AreEqual("(A : 0) - (B : 1290) - (C : 515) - (D : 600)", HelpBookseller.stockSummary(art, cd));
        }

        [Test]
        public void Test3()
        {
            string[] art = new string[] {"CBART 20", "CDXEF 50", "BKWRK 25", "BTSQZ 89", "DRTYM 60"};
            String[] cd = new String[] {"A", "B", "C", "W"};
            Assert.AreEqual("(A : 0) - (B : 114) - (C : 70) - (W : 0)", HelpBookseller.stockSummary(art, cd));
        }

        [Test]
        public void Test4()
        {
            string[] art = new string[] { };
            String[] cd = new String[] {"B", "R", "D", "X"};
            Assert.AreEqual("", HelpBookseller.stockSummary(art, cd));
        }

        [Test]
        public void Test5()
        {
            string[] art = new string[] {"ROXANNE 102", "RHODODE 123", "BKWRKAA 125", "BTSQZFG 239", "DRTYMKH 060"};
            String[] cd = new String[] { };
            Assert.AreEqual("", HelpBookseller.stockSummary(art, cd));
        }

        [Test]
        public void Test6()
        {
            string[] art = new string[] {"ROXANNE 102", "RHODODE 123", "BKWRKAA 125", "BTSQZFG 239", "DRTYMKH 060"};
            String[] cd = new String[] {"B", "R", "D", "X"};
            Assert.AreEqual("(B : 364) - (R : 225) - (D : 60) - (X : 0)", HelpBookseller.stockSummary(art, cd));
        }
    }
}