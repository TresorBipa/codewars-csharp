using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun320ScratchlotteryITests
    {
        static object[] TestCases =
        {
            new object[]
            {
                new string[]
                {
                    "tiger tiger tiger 100",
                    "rabbit dragon snake 100",
                    "rat ox pig 1000",
                    "dog cock sheep 10",
                    "horse monkey rat 5",
                    "dog dog dog 1000"
                },
                1100
            }
        };
    }

    [TestFixture]
    public class LottoChecker
    {
        [Test, TestCaseSource(typeof(SimpleFun320ScratchlotteryITests), "TestCases")]
        public void SampleTest(string[] lottery, int expected)
        {
            Assert.AreEqual(expected, SimpleFun320ScratchlotteryI.Scratch(lottery));
        }
    }
}