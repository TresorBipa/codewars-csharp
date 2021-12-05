using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun131LearnCharitableGameTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun131LearnCharitableGame();

            Assert.AreEqual(false, kata.LearnCharitableGame(new int[] {100, 100, 100, 90, 1, 0, 0}));

            Assert.AreEqual(false, kata.LearnCharitableGame(new int[] {0, 0, 0, 0}));

            Assert.AreEqual(true, kata.LearnCharitableGame(new int[] {0, 56, 100}));

            Assert.AreEqual(false, kata.LearnCharitableGame(new int[] {33, 19, 38, 87, 93, 4}));

            Assert.AreEqual(true, kata.LearnCharitableGame(new int[] {11}));
        }
    }
}