using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RedKnightTests
    {
        [Test]
        public void ExampleTests()
        {
            var actual = KataRedKnight.RedKnight(0, 8);
            var expected = ("White", 16);
            AssertEquivalence(expected, actual);

            actual = KataRedKnight.RedKnight(0, 7);
            expected = ("Black", 14);
            AssertEquivalence(expected, actual);

            actual = KataRedKnight.RedKnight(1, 6);
            expected = ("Black", 12);
            AssertEquivalence(expected, actual);

            actual = KataRedKnight.RedKnight(1, 5);
            expected = ("White", 10);
            AssertEquivalence(expected, actual);
        }

        private static void AssertEquivalence(
            (string Color, long Distance) expected,
            (string Color, long Distance) actual)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected.Color, actual.Color);
                Assert.AreEqual(expected.Distance, actual.Distance);
            });
        }
    }
}