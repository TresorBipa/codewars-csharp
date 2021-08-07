using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HammingDistancePart1BinaryCodesTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual(2, HammingDistancePart1BinaryCodes.HammingDistance("100101", "101001"));
            Assert.AreEqual(4, HammingDistancePart1BinaryCodes.HammingDistance("1010", "0101"));
            Assert.AreEqual(9,
                HammingDistancePart1BinaryCodes.HammingDistance("100101011011010010010", "101100010110010110101"));
        }
    }
}