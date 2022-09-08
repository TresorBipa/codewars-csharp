using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu;

[TestFixture]
public class AsciiFun2FunnyDotsTests
{
    [Test]
    public void SampleTests()
    {
        Assertion((1, 1), "+---+\n| o |\n+---+");
        Assertion((3, 2), "+---+---+---+\n| o | o | o |\n+---+---+---+\n| o | o | o |\n+---+---+---+");
    }

    private static void Assertion((int, int) inputs, string expected) =>
        Assert.AreEqual(
            expected,
            AsciiFun2FunnyDots.Dot(inputs.Item1, inputs.Item2),
            $"\n  N = {inputs.Item1}" +
            $"\n  M = {inputs.Item2}"
        );
}