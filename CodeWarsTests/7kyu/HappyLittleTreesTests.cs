using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HappyLittleTreesTests
    {
        [Test]
        public static void EmptyTree()
        {
            Pre sol = new Pre();
            HappyLittleTrees happy = new HappyLittleTrees();
            Console.WriteLine(happy.Description());
            Assert.AreEqual(sol.sol1, happy.Description());
        }

        [Test]
        public static void BadTree()
        {
            Pre sol = new Pre();
            HappyLittleTrees happy = new HappyLittleTrees();
            happy.GrowBranches();
            happy.Ouch(1);
            happy.GrowTrunk();
            Console.WriteLine(happy.Description());
            Assert.AreEqual(sol.sol2, happy.Description());
        }

        [Test]
        public static void GrownTree()
        {
            Pre sol = new Pre();
            HappyLittleTrees happy = new HappyLittleTrees();
            happy.NewBranch();
            happy.GrowTrunk();
            happy.GrowBranches();
            happy.GrowTrunk();
            happy.NewBranch();
            happy.NewBranch();
            happy.NewBranch();
            happy.NewBranch();
            happy.GrowBranches();
            happy.Ouch(3);
            happy.GrowTrunk();
            happy.GrowTrunk();
            happy.NewBranch();
            happy.GrowBranches();
            Console.WriteLine(happy.Description());
            Assert.AreEqual(sol.sol3, happy.Description());
        }
    }
}