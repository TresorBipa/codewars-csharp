using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GeneticAlgorithmSeries2MutationTests
    {
        private Random random = new Random();
        private GeneticAlgorithmSeries2Mutation kata = new GeneticAlgorithmSeries2Mutation();

        [Test]
        public void Mutate100()
        {
            Assert.AreEqual("1111", kata.Mutate("0000", 1));
            Assert.AreEqual("0000", kata.Mutate("1111", 1));
        }

        [Test]
        public void Mutate0()
        {
            Assert.AreEqual("0000", kata.Mutate("0000", 0));
            Assert.AreEqual("1111", kata.Mutate("1111", 0));
        }
    }
}