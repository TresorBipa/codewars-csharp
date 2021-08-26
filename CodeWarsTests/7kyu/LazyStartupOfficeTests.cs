using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class LazyStartupOfficeTests
    {
        [Test]
        public void ExampleTests()
        {
            var testInput = new string[][] {new[] {"Bob", "Nora"}, new[] {"Ruby", "Carl"}};
            Assert.AreEqual(new[] {"Bob", "Nora", "Carl", "Ruby"}, LazyStartupOffice.BinRota(testInput));

            testInput = new string[][] {new[] {"Billy"}};
            Assert.AreEqual(new[] {"Billy"}, LazyStartupOffice.BinRota(testInput));

            testInput = new string[][] {new[] {"Billy", "Nancy"}};
            Assert.AreEqual(new[] {"Billy", "Nancy"}, LazyStartupOffice.BinRota(testInput));

            testInput = new string[][] {new[] {"Billy"}, new[] {"Megan"}, new[] {"Aki"}, new[] {"Arun"}, new[] {"Joy"}};
            Assert.AreEqual(new[] {"Billy", "Megan", "Aki", "Arun", "Joy"}, LazyStartupOffice.BinRota(testInput));

            testInput = new string[][]
            {
                new[] {"Sam", "Nina", "Tim", "Helen", "Gurpreet", "Edward", "Holly", "Eliza"},
                new[] {"Billy", "Megan", "Aki", "Arun", "Joy", "Anish", "Lee", "Maryan"},
                new[] {"Nick", "Josh", "Pete", "Kavita", "Daisy", "Francesca", "Alfie", "Macy"}
            };
            
            Assert.AreEqual(
                new[]
                {
                    "Sam", "Nina", "Tim", "Helen", "Gurpreet", "Edward", "Holly", "Eliza", "Maryan", "Lee", "Anish",
                    "Joy", "Arun", "Aki", "Megan", "Billy", "Nick", "Josh", "Pete", "Kavita", "Daisy", "Francesca",
                    "Alfie", "Macy"
                }, LazyStartupOffice.BinRota(testInput));

            testInput = new string[][]
            {
                new[] {"Stefan", "Raj", "Marie"}, new[] {"Alexa", "Amy", "Edward"}, new[] {"Liz", "Claire", "Juan"},
                new[] {"Dee", "Luke", "Elle"}
            };
            
            Assert.AreEqual(
                new[]
                {
                    "Stefan", "Raj", "Marie", "Edward", "Amy", "Alexa", "Liz", "Claire", "Juan", "Elle", "Luke", "Dee"
                }, LazyStartupOffice.BinRota(testInput));
        }
    }
}