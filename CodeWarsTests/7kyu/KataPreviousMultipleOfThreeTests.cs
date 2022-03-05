using CodeWars._7kyu;
using NUnit.Framework;

namespace CodeWarsTests._7kyu
{
    [TestFixture]
    public class KataPreviousMultipleOfThreeTests
    {
        private static void Act(int n, int? expected)
        {
            var msg = $"Invalid answer for n: {n}";
            var actual = KataPreviousMultipleOfThree.PreviousMultipleOfThree(n);
            Assert.AreEqual(expected, actual, msg);
        }

        [TestCase(1, null)]
        [TestCase(25, null)]
        [TestCase(36, 36)]
        [TestCase(1244, 12)]
        [TestCase(952406, 9)]
        public void SampleTests(int n, int? expected)
        {
            Act(n, expected);
        }
    }
}