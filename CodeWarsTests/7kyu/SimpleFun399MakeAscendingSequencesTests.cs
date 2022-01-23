using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun399MakeAscendingSequencesTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(6, SimpleFun399MakeAscendingSequences.MakeSequences(6));

            Assert.AreEqual(14, SimpleFun399MakeAscendingSequences.MakeSequences(10));

            Assert.AreEqual(1981471878, SimpleFun399MakeAscendingSequences.MakeSequences(1000));
        }
    }
}