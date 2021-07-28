using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GeneticAlgorithmSeries3CrossoverTests
    {
        private GeneticAlgorithmSeries3Crossover kata = new GeneticAlgorithmSeries3Crossover();

        [Test]
        public void _0_Crossover_Basic_Tests()
        {
            Assert.AreEqual("111", kata.Crossover("110", "001", 2).ElementAt(0));
            Assert.AreEqual("000", kata.Crossover("110", "001", 2).ElementAt(1));

            Assert.AreEqual("111110", kata.Crossover("111000", "000110", 3).ElementAt(0));
            Assert.AreEqual("000000", kata.Crossover("111000", "000110", 3).ElementAt(1));
        }
    }
}