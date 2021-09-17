using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataNextPerfectSquareTests
    {
        [TestFixture]
        public class Sample_Tests
        {
            private static IEnumerable<TestCaseData> testCases
            {
                get
                {
                    yield return new TestCaseData(6).Returns(9);
                    yield return new TestCaseData(36).Returns(49);
                    yield return new TestCaseData(0).Returns(1);
                    yield return new TestCaseData(-5).Returns(0);
                }
            }

            [Test, TestCaseSource("testCases")]
            public long SampleTest(long n) => KataNextPerfectSquare.NextPerfectSquare(n);
        }
    }
}