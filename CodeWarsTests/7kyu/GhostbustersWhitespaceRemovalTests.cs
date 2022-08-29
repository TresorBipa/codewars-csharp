using CodeWars._7kyu;
using NUnit.Framework;

namespace CodeWarsTests._7kyu;

[TestFixture]
public class GhostbustersWhitespaceRemovalTests
{
    [Test]
    public void GenericTests()
    {
        Assert.AreEqual("Factory", GhostbustersWhitespaceRemoval.GhostBusters("Factor y"),
            "Nope, there may still be a ghost in the building. Try again.");
        Assert.AreEqual("Office", GhostbustersWhitespaceRemoval.GhostBusters("O  f fi ce"),
            "Nope, there may still be a ghost in the building. Try again.");
        Assert.AreEqual("You just wanted my autograph didn't you?",
            GhostbustersWhitespaceRemoval.GhostBusters("BusStation"),
            "Nope, as there were no ghosts in the BusStation you need to return a witty retort.");
    }
}