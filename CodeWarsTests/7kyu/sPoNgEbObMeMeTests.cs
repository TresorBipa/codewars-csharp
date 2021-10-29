using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class sPoNgEbObMeMeTests
    {
        private static object[] Basic_Test_Cases = new object[]
        {
            new object[] { "stop Making spongebob Memes!", "StOp mAkInG SpOnGeBoB MeMeS!" },
            new object[] { "colored teens cant Be successful in tech", "CoLoReD TeEnS CaNt bE SuCcEsSfUl iN TeCh" },
        };

        [Test, TestCaseSource(typeof(sPoNgEbObMeMeTests), "Basic_Test_Cases")]
        public void Basic_Test(string test, string expected)
        {
            Assert.AreEqual(expected, sPoNgEbObMeMe.SpongeMeme(test));
        }
    }
}