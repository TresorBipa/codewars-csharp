using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MakeSmallWordsBigTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("THE qck brwn FOX jmps vr THE lzy DOG",
                MakeSmallWordsBig.SmallWordHelper("The quick brown fox jumps over the lazy dog"));

            Assert.AreEqual("I'M jst A smll wrd frm A smll wrd fmly",
                MakeSmallWordsBig.SmallWordHelper("I'm just a small word from a small word family"));
        }
    }
}