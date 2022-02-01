using System;
using CodeWars;
using CodeWars._6kyu;
using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class BigPronicChallengeTests
    {
        [TestCase(1L << 24)]
        [TestCase(1L << 25)]
        [TestCase(1L << 26)]
        [TestCase(1L << 30)]
        [TestCase(1L << 31)]
        [TestCase(185363L << 14)]
        public void IsPronicTests(long basis)
        {
            checked
            {
                int range = (int) Math.Min(basis - 1, 10000);
                for (long i = 0; i < range; ++i)
                {
                    long cand = basis + i;
                    long pronic = cand * (cand + 1);
                    IsTrue(BigPronicChallenge.IsPronic(pronic), pronic.ToString());
                }
            }
        }

        [TestCase(1L << 24)]
        [TestCase(1L << 25)]
        [TestCase(1L << 26)]
        [TestCase(1L << 30)]
        [TestCase(1L << 31)]
        [TestCase(185363L << 14)]
        public void IsNotPronicTests(long basis)
        {
            checked
            {
                int range = (int) Math.Min(basis - 1, 10000);
                for (long i = 1; i < range; ++i)
                {
                    long cand = basis + i;
                    long notPronic = cand * (cand + 1) - i;
                    IsFalse(BigPronicChallenge.IsPronic(notPronic), notPronic.ToString());
                }
            }
        }

        [TestCase(0, ExpectedResult = true)]
        [TestCase(1, ExpectedResult = false)]
        [TestCase(2, ExpectedResult = true)]
        [TestCase(6, ExpectedResult = true)]
        [TestCase(12, ExpectedResult = true)]
        [TestCase(20, ExpectedResult = true)]
        [TestCase(30, ExpectedResult = true)]
        [TestCase(42, ExpectedResult = true)]
        [TestCase(long.MinValue, ExpectedResult = false)]
        [TestCase(long.MinValue, ExpectedResult = false)]
        [TestCase(long.MinValue / 2, ExpectedResult = false)]
        [TestCase(long.MaxValue, ExpectedResult = false)]
        [TestCase(9223372033963249500L, ExpectedResult = true)]
        public bool IndividualPronicTests(long n)
        {
            return BigPronicChallenge.IsPronic(n);
        }

        [Test]
        public void RandomTests()
        {
            checked
            {
                var r = new Random();
                for (int i = 0; i < 100000; ++i)
                {
                    long cand = r.Next();
                    long pronic = cand * (cand - 1);
                    IsTrue(BigPronicChallenge.IsPronic(pronic), pronic.ToString());
                    long notPronic = pronic + 2;
                    IsFalse(BigPronicChallenge.IsPronic(notPronic), notPronic.ToString());
                }
            }
        }
    }
}