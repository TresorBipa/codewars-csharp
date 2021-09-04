using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MeanVsMedianTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("same", KataMeanVsMedian.MeanVsMedian(new int[] {1, 1, 1}));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("mean", KataMeanVsMedian.MeanVsMedian(new int[] {1, 2, 37}));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("median", KataMeanVsMedian.MeanVsMedian(new int[] {7, 14, -70}));
        }
    }
}