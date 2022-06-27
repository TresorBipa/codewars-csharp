using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu;

[TestFixture]
public class PairOfGlovesTests
{
    [Test]
    public void SampleTests()
    {
        Assertion(0, new string[] {"Green", "Blue", "Purple", "Gray"});
        Assertion(0, new string[] { });
        Assertion(0, new string[] {"Purple"});

        Assertion(1, new string[] {"Blue", "Purple", "Blue", "Gray", "Lime", "Black"});
        Assertion(1, new string[] {"Blue", "Aqua", "Blue", "Teal", "Blue", "Black"});

        Assertion(2, new string[] {"Blue", "Aqua", "Blue", "Brown", "Blue", "Orange", "Aqua"});
    }

    private static void Assertion(int expected, string[] input) =>
        Assert.AreEqual(
            expected,
            PairOfGloves.NumberOfPairs(input),
            $"Input: [{string.Join(", ", input)}]"
        );
}