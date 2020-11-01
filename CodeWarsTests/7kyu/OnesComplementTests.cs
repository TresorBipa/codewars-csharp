using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataOnesComplementTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual("1", KataOnesComplement.OnesComplement("0"));
            Assert.AreEqual("0", KataOnesComplement.OnesComplement("1"));
            Assert.AreEqual("01", KataOnesComplement.OnesComplement("10"));
            Assert.AreEqual("10", KataOnesComplement.OnesComplement("01"));
            Assert.AreEqual("0010", KataOnesComplement.OnesComplement("1101"));
        }
    }
}