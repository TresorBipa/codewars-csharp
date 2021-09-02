using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MakesSentenceTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(
                MakesSentence.MakesTheSentence(new List<char> {'D', 'u', 'c', 'k', 's', 'q', 'u', 'a', 'c', 'k', '.'},
                    "Ducks quack."), Is.EqualTo(true));

            Assert.That(MakesSentence.MakesTheSentence(new List<char> {'S', 'h', 'e', 'a', 'd', 's', '.'}, "She adds."),
                Is.EqualTo(false));
        }
    }
}