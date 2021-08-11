using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HelpSuzukiCompleteHisChoresTests
    {
        [Test]
        public void BasicTest1()
        {
            var chores = new[] {5, 2, 1, 6, 4, 4};
            var expected = new[] {7, 7, 8};
            Assert.AreEqual(expected, HelpSuzukiCompleteHisChores.ChoreAssignment(chores));
        }

        [Test]
        public void BasicTest2()
        {
            var chores = new[] {1, 5, 2, 8, 4, 9, 6, 4, 2, 2, 2, 9};
            var expected = new[] {7, 8, 8, 10, 10, 11};
            Assert.AreEqual(expected, HelpSuzukiCompleteHisChores.ChoreAssignment(chores));
        }

        [Test]
        public void BasicTest3()
        {
            var chores = new[] {5, 8, 3, 5, 3, 10, 5, 3, 10, 2, 4, 8, 7, 3, 9, 6};
            var expected = new[] {10, 11, 11, 11, 11, 12, 12, 13};
            Assert.AreEqual(expected, HelpSuzukiCompleteHisChores.ChoreAssignment(chores));
        }

        [Test]
        public void BasicTest4()
        {
            var chores = new[] {9, 2, 10, 10, 5, 5, 8, 7, 4, 2, 8, 3, 6, 8, 7, 3, 6, 2};
            var expected = new[] {11, 11, 11, 12, 12, 12, 12, 12, 12};
            Assert.AreEqual(expected, HelpSuzukiCompleteHisChores.ChoreAssignment(chores));
        }

        [Test]
        public void BasicTest5()
        {
            var chores = new[] {1, 6, 5, 5, 1, 10, 10, 9, 2, 10, 3, 9, 5, 4, 5, 6, 1, 9, 1, 8};
            var expected = new[] {10, 10, 11, 11, 11, 11, 11, 11, 12, 12};
            Assert.AreEqual(expected, HelpSuzukiCompleteHisChores.ChoreAssignment(chores));
        }
    }
}