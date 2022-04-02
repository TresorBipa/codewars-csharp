using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DoesMyNumberLookBigInThisTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(1)
                    .Returns(true)
                    .SetDescription("1 is narcissitic");
                yield return new TestCaseData(371)
                    .Returns(true)
                    .SetDescription("371 is narcissitic");
            }
        }

        [Test, TestCaseSource("testCases")]
        public bool Test(int n) => DoesMyNumberLookBigInThis.Narcissistic(n);
    }
}