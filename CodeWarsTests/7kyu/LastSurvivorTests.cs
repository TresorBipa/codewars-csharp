using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class LastSurvivorTests
    {
        private static void Act(string letters, int[] coords, string expected)
        {
            var msg = $"Invalid answer for letters: \"{letters}\" and coords: [{string.Join(",", coords)}]";
            var actual = KataLastSurvivor.LastSurvivor(letters, coords);
            Assert.AreEqual(expected, actual, msg);
        }

        [TestCase("abc", new int[] {1, 1}, "a", Description = "letters: \"abc\"  coords: [1, 1]")]
        [TestCase("kbc", new int[] {0, 1}, "b", Description = "letters: \"kbc\"  coords: [0, 1]")]
        [TestCase("zbk", new int[] {2, 1}, "z", Description = "letters: \"zbk\"  coords: [2, 1]")]
        [TestCase("c", new int[0], "c", Description = "letters: \"c\"  coords: []")]
        [TestCase("foiflxtpicahhkqjswjuyhmypkrdbwnmwbrrvdycqespfvdviucjoyvskltqaqirtjqulprjjoaiagobpftywabqjdmiofpsr",
            new int[]
            {
                8, 59, 52, 93, 21, 40, 88, 85, 59, 10, 82, 18, 74, 59, 51, 47, 75, 49, 23, 56, 1, 33, 39, 33, 34, 44,
                25, 0, 51, 25, 36, 32, 57, 10, 57, 12, 51, 55, 24, 55, 31, 49, 6, 15, 10, 48, 27, 29, 38, 30, 35, 42,
                23, 32, 9, 39, 39, 36, 8, 29, 2, 33, 14, 3, 13, 25, 9, 25, 18, 10, 1, 2, 20, 8, 2, 11, 5, 7, 0, 10, 10,
                8, 12, 3, 5, 1, 7, 7, 5, 1, 4, 0, 4, 0, 0, 1
            }, "d", Description = "long example")]
        public void SampleTests(string letters, int[] coords, string expected)
        {
            Act(letters, coords, expected);
        }
    }
}