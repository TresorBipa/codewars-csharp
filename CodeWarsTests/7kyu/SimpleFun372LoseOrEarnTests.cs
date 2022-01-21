using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun372LoseOrEarnTests
    {
        [TestFixture]
        public class SolutionTest
        {
            [Test, Description("It should works for basic tests.")]
            public void SampleTest()
            {
                Assert.That(SimpleFun372LoseOrEarn.LoseOrEarn(40, 70, 100, 30), Is.EqualTo("Lost $70"));
                Assert.That(SimpleFun372LoseOrEarn.LoseOrEarn(40, 70, 50, 20), Is.EqualTo("Lost $20"));
                Assert.That(SimpleFun372LoseOrEarn.LoseOrEarn(14604, 32391, 3902, 153), Is.EqualTo("Earned $13885"));
            }
        }
    }
}