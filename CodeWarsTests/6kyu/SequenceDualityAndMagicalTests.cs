using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SequenceDualityAndMagicalTests
    {
        private static void Act(int[] seq, int[] expected)
        {
            var actual = SequenceDualityAndMagical.Delta(seq);
            var msg = $"\nseq = {Formatter.FormatArray(seq)}\n" + Formatter.FormatMessage(actual, expected);
            CollectionAssert.AreEqual(expected, actual, msg);
        }

        [TestCase(new int[] {1, -2, 4, -8, 16, -32}, new int[] {3, -6, 12, -24, 48})]
        public void GeneralCase(int[] seq, int[] expected)
        {
            Act(seq, expected);
        }

        [TestCase(new int[] {17, 12}, new int[] {5})]
        public void MinimalCase(int[] seq, int[] expected)
        {
            Act(seq, expected);
        }
    }

    [TestFixture]
    public class DualSeqTests
    {
        private static void Act(int[] seq, int[] expected)
        {
            var actual = SequenceDualityAndMagical.DualSeq(seq);
            var msg = $"\nseq = {Formatter.FormatArray(seq)}\n" + Formatter.FormatMessage(actual, expected);
            CollectionAssert.AreEqual(expected, actual, msg);
        }

        [TestCase(new int[] {40, 66, 73, -76, 95, -88, 88, -96}, new int[] {40, 66, 73, -76, 95, -88, 88, -96})]
        public void DualProperty(int[] seq, int[] expected)
        {
            Act(SequenceDualityAndMagical.DualSeq(seq), expected);
        }

        [TestCase(new int[] {1, 1, 1, 1, 1}, new int[] {1, 0, 0, 0, 0})]
        [TestCase(new int[] {1, 4, 9, 16, 25, 36, 49}, new int[] {1, -3, 2, 0, 0, 0, 0})]
        [TestCase(new int[] {95, -11, 76, -94, -20, 98, -19}, new int[] {95, 106, 193, 450, 951, 1652, 2274})]
        public void GeneralCase(int[] seq, int[] expected)
        {
            Act(seq, expected);
        }

        [TestCase(new int[] {1}, new int[] {1})]
        public void MinimalCase(int[] seq, int[] expected)
        {
            Act(seq, expected);
        }
    }

    [TestFixture]
    public class ExtraPolTests
    {
        private static void Act(int[] seq, int n, int[] expected)
        {
            var actual = SequenceDualityAndMagical.ExtraPol(seq, n);
            var msg = $"\nseq = {Formatter.FormatArray(seq)}\nn = {n}\n" + Formatter.FormatMessage(actual, expected);
            CollectionAssert.AreEqual(expected, actual, msg);
        }

        [TestCase(new int[] {1}, 5, new int[] {1, 1, 1, 1, 1, 1})]
        public void SequencesOfLength1(int[] seq, int n, int[] expected)
        {
            Act(seq, n, expected);
        }

        [TestCase(new int[] {3, 2}, 0, new int[] {3, 2})]
        public void N_zero(int[] seq, int n, int[] expected)
        {
            Act(seq, n, expected);
        }

        [TestCase(new int[] {1, 4, 9}, 5, new int[] {1, 4, 9, 16, 25, 36, 49, 64})]
        [TestCase(new int[] {4, 16, 36}, 5, new int[] {4, 16, 36, 64, 100, 144, 196, 256})]
        [TestCase(new int[] {216, 125, 64, 27}, 7, new int[] {216, 125, 64, 27, 8, 1, 0, -1, -8, -27, -64})]
        public void GeneralCase(int[] seq, int n, int[] expected)
        {
            Act(seq, n, expected);
        }
    }

    static class Formatter
    {
        public static string FormatArray(int[] seq) => seq == null ? "<null>" : $"[{string.Join(", ", seq)}]";

        public static string FormatMessage(int[] seq, int[] expected) =>
            $"\nInvalid answer:\n  Expected: {FormatArray(expected)}\n  Actual:   {FormatArray(seq)}\n\n";
    }
}