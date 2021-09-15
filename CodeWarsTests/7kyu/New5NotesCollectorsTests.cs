using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class New5NotesCollectorsTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(188, New5NotesCollectors.GetNewNotes(2000, new int[] {500, 160, 400}));
            Assert.AreEqual(122, New5NotesCollectors.GetNewNotes(1260, new int[] {500, 50, 100}));
            Assert.AreEqual(95, New5NotesCollectors.GetNewNotes(3600, new int[] {1800, 350, 460, 500, 15}));
            Assert.AreEqual(86, New5NotesCollectors.GetNewNotes(1995, new int[] {1500, 19, 44}));
        }
    }
}