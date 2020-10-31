using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class OnceRollableDiceTests
    {
        [Test, Description("I should be able to name my character")]
        public void NameTest()
        {
            Character balthazaar = new Character("Balthazaar", 30);
            Assert.AreEqual("Balthazaar", balthazaar.Name);
        }
    
        [Test, Description("Balthazaar's attack should return a random value each time")]
        public void RandomTest()
        {
            Character balthazaar = new Character("Balthazaar", 30);
      
            // attackBuffer should contain a variety of damage values
            int[] attackBuffer = new int[100].Select(_ => balthazaar.Attack()).ToArray();
            int distinct = attackBuffer.Distinct().Count();
            Assert.Greater(distinct, 4, $"Seems like your random magic went wrong! Out of 100 times, attack() only generated {distinct} distinct value(s)!");
      
            // attackBuffer should only contain valid attack ranges as specified by the damage formula
            Assert.That(attackBuffer.All(v => 30 < v && v < 51), "Balthazaar's attacks aren't based on the opness I gave in the constructor.");
        }
    }
}