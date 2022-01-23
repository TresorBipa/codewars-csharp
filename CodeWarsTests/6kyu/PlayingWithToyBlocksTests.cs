using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PlayingWithToyBlocksTests
    {
        [Test, Description("Example Tests")]
        [TestCase(new int[] {3, 1, 3, 1, 3, 1, 3, 2}, ExpectedResult = false)]
        [TestCase(new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, ExpectedResult = true)]
        [TestCase(new int[] {3, 2, 3, 3, 3, 3, 3, 3, 4, 2, 4}, ExpectedResult = false)]
        [TestCase(new int[] {4, 3, 2, 1, 3, 1, 1, 2, 3, 1, 1}, ExpectedResult = true)]
        [TestCase(new int[] {1, 3, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1}, ExpectedResult = false)]
        public bool BasicTests(int[] blocks)
        {
            return PlayingWithToyBlocks.BuildSquare(blocks);
        }
    }
}