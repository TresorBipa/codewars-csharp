using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SortArrays_1Tests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("one,three,two", string.Join(",", SortArrays_1.SortMe(new[] {"one", "two", "three"})));
        }
    }
}