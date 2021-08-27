using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class LetterboxPaintSquadTests
    {
        [Test, Description("Sample Test")]
        public void ExampleTest()
        {
            Assert.AreEqual(new int[] {1, 9, 6, 3, 0, 1, 1, 1, 1, 1},
                LetterboxPaintSquad.PaintLetterBoxes(125, 132).ToArray());
        }
    }
}