using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SmallestPermutationTests
    {
        [Test]
        public void KataTest()
        {
            SmallestPermutation kata = new SmallestPermutation();

            Assert.AreEqual(-20, kata.MinPermutation(-20));
            Assert.AreEqual(-23, kata.MinPermutation(-32));
            Assert.AreEqual(0, kata.MinPermutation(0));
            Assert.AreEqual(10, kata.MinPermutation(10));
            Assert.AreEqual(23499, kata.MinPermutation(29394));
        }
    }
}