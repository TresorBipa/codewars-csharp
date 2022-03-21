using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CheckingGroupsTests
    {
        [TestCase("()", true)]
        [TestCase("({", false)]
        public void Tests(string input, bool expected)
        {
            Assert.AreEqual(expected, CheckingGroups.Check(input));
        }
    }
}