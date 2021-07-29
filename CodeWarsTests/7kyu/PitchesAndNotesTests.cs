using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PitchesAndNotesTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(PitchesAndNotes.GetNote(440), Is.EqualTo("A"));
            Assert.That(PitchesAndNotes.GetNote(220), Is.EqualTo("A"));
            Assert.That(PitchesAndNotes.GetNote(880), Is.EqualTo("A"));

            Assert.That(PitchesAndNotes.GetNote(523.25), Is.EqualTo("C"));
            Assert.That(PitchesAndNotes.GetNote(261.625), Is.EqualTo("C"));
            Assert.That(PitchesAndNotes.GetNote(1046.5), Is.EqualTo("C"));
        }
    }
}