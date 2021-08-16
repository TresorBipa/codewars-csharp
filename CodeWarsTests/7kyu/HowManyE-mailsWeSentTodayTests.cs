using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HowManyE_mailsWeSentTodayTests
    {
        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void ShouldRoundUp()
            {
                Assert.AreEqual("10%", HowManyE_mailsWeSentToday.CountEmails(100, 1000));
            }
        }
    }
}