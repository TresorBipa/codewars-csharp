using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataUpturnNumeralTriangleTests
    {
        [Test]
        public void Pattern7()
        {
            string expectetPattern =
                " 1 1 1 1 1 1 1\n  2 2 2 2 2 2\n   3 3 3 3 3\n    4 4 4 4\n     5 5 5\n      6 6\n       7";
            Assert.AreEqual(expectetPattern, KataUpturnNumeralTriangle.UpturnNumeralTriangle(7));
        }

        [Test]
        public void Pattern12()
        {
            string expectetPattern =
                " 1 1 1 1 1 1 1 1 1 1 1 1\n  2 2 2 2 2 2 2 2 2 2 2\n   3 3 3 3 3 3 3 3 3 3\n    4 4 4 4 4 4 4 4 4\n     5 5 5 5 5 5 5 5\n      6 6 6 6 6 6 6\n       7 7 7 7 7 7\n        8 8 8 8 8\n         9 9 9 9\n          0 0 0\n           1 1\n            2";
            Assert.AreEqual(expectetPattern, KataUpturnNumeralTriangle.UpturnNumeralTriangle(12));
        }

        [Test]
        public void Pattern21()
        {
            string expectetPattern =
                " 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1\n  2 2 2 2 2 2 2 2 2 2 2 2 2 2 2 2 2 2 2 2\n   3 3 3 3 3 3 3 3 3 3 3 3 3 3 3 3 3 3 3\n    4 4 4 4 4 4 4 4 4 4 4 4 4 4 4 4 4 4\n     5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5\n      6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6\n       7 7 7 7 7 7 7 7 7 7 7 7 7 7 7\n        8 8 8 8 8 8 8 8 8 8 8 8 8 8\n         9 9 9 9 9 9 9 9 9 9 9 9 9\n          0 0 0 0 0 0 0 0 0 0 0 0\n           1 1 1 1 1 1 1 1 1 1 1\n            2 2 2 2 2 2 2 2 2 2\n             3 3 3 3 3 3 3 3 3\n              4 4 4 4 4 4 4 4\n               5 5 5 5 5 5 5\n                6 6 6 6 6 6\n                 7 7 7 7 7\n                  8 8 8 8\n                   9 9 9\n                    0 0\n                     1";
            Assert.AreEqual(expectetPattern, KataUpturnNumeralTriangle.UpturnNumeralTriangle(21));
        }
    }
}