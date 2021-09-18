using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NotAllButSometimesAllTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("hs s a string",
                NotAllButSometimesAll.Remove("this is a string", new Dictionary<char, int> {{'t', 1}, {'i', 2}}));

            Assert.AreEqual("hello world",
                NotAllButSometimesAll.Remove("hello world", new Dictionary<char, int> {{'x', 5}, {'i', 2}}));

            Assert.AreEqual("pples d bnns",
                NotAllButSometimesAll.Remove("apples and bananas", new Dictionary<char, int> {{'a', 50}, {'n', 1}}));

            Assert.AreEqual("", NotAllButSometimesAll.Remove("a", new Dictionary<char, int> {{'a', 1}, {'n', 1}}));

            Assert.AreEqual("",
                NotAllButSometimesAll.Remove("codewars",
                    new Dictionary<char, int>
                        {{'c', 5}, {'o', 1}, {'d', 1}, {'e', 1}, {'w', 1}, {'z', 1}, {'a', 1}, {'r', 1}, {'s', 1}}));
        }
    }
}