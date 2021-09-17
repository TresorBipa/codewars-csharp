using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CountConsonantsTests
    {
        [Test]
        [TestCase("", ExpectedResult = 0)]
        [TestCase("aaaaa", ExpectedResult = 0)]
        [TestCase("Bbbbb", ExpectedResult = 5)]
        [TestCase("helLo world", ExpectedResult = 7)]
        [TestCase("h^$&^#$&^elLo world", ExpectedResult = 7)]
        [TestCase("012456789", ExpectedResult = 0)]
        [TestCase("012345_Cb", ExpectedResult = 2)]
        public static int FixedTest(string s)
        {
            return CountConsonants.ConsonantCount(s);
        }
    }
}