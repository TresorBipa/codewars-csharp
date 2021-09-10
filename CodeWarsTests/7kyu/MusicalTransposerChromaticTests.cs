using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MusicalTransposerChromaticTests
    {
        [Test, Description("Should return the same note.")]
        public void UnisonTests()
        {
            Assert.AreEqual("A", MusicalTransposerChromatic.Transpose("A", 0));
            Assert.AreEqual("C", MusicalTransposerChromatic.Transpose("C", 0));
            Assert.AreEqual("F#", MusicalTransposerChromatic.Transpose("F#", 0));
        }

        [Test, Description("Should return the same note.")]
        public void OctaveTests()
        {
            Assert.AreEqual("C#", MusicalTransposerChromatic.Transpose("C#", 12));
            Assert.AreEqual("E", MusicalTransposerChromatic.Transpose("E", 12));
            Assert.AreEqual("G#", MusicalTransposerChromatic.Transpose("G#", 12));
        }

        [Test, Description("Should return the same note.")]
        public void SubOctaveTests()
        {
            Assert.AreEqual("A#", MusicalTransposerChromatic.Transpose("A#", -12));
            Assert.AreEqual("D", MusicalTransposerChromatic.Transpose("D", -12));
            Assert.AreEqual("F", MusicalTransposerChromatic.Transpose("F", -12));
        }

        [Test, Description("Should return the transposition of the given note by the given number of semi-tones.")]
        public void RandomIntervals()
        {
            Assert.AreEqual("C#", MusicalTransposerChromatic.Transpose("A", 4));
            Assert.AreEqual("B", MusicalTransposerChromatic.Transpose("A", -10));
            Assert.AreEqual("F", MusicalTransposerChromatic.Transpose("A#", 7));
            Assert.AreEqual("A", MusicalTransposerChromatic.Transpose("A#", -1));
            Assert.AreEqual("G#", MusicalTransposerChromatic.Transpose("B", 9));
            Assert.AreEqual("F", MusicalTransposerChromatic.Transpose("B", -6));
            Assert.AreEqual("G#", MusicalTransposerChromatic.Transpose("C", 8));
            Assert.AreEqual("A", MusicalTransposerChromatic.Transpose("C", -3));
            Assert.AreEqual("F#", MusicalTransposerChromatic.Transpose("C#", 5));
            Assert.AreEqual("D", MusicalTransposerChromatic.Transpose("C#", -11));
            Assert.AreEqual("E", MusicalTransposerChromatic.Transpose("D", 2));
            Assert.AreEqual("G", MusicalTransposerChromatic.Transpose("D", -7));
            Assert.AreEqual("D", MusicalTransposerChromatic.Transpose("D#", 11));
            Assert.AreEqual("B", MusicalTransposerChromatic.Transpose("D#", -4));
            Assert.AreEqual("G", MusicalTransposerChromatic.Transpose("E", 3));
            Assert.AreEqual("G", MusicalTransposerChromatic.Transpose("E", -9));
            Assert.AreEqual("D#", MusicalTransposerChromatic.Transpose("F", 10));
            Assert.AreEqual("D#", MusicalTransposerChromatic.Transpose("F", -2));
            Assert.AreEqual("G", MusicalTransposerChromatic.Transpose("F#", 1));
            Assert.AreEqual("C#", MusicalTransposerChromatic.Transpose("F#", -5));
            Assert.AreEqual("C#", MusicalTransposerChromatic.Transpose("G", 6));
            Assert.AreEqual("B", MusicalTransposerChromatic.Transpose("G", -8));
            Assert.AreEqual("D#", MusicalTransposerChromatic.Transpose("G#", 7));
            Assert.AreEqual("E", MusicalTransposerChromatic.Transpose("G#", -4));
        }
    }
}