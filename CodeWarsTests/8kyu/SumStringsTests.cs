﻿using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumStringsTests
    {
        [Test(Description = "Tests")]
        public void Tests()
        {
            Assert.AreEqual("9", SumStrings.StringsSum("4", "5"));
            Assert.AreEqual("39", SumStrings.StringsSum("34", "5"));
            Assert.AreEqual("9", SumStrings.StringsSum("", "9"));
            Assert.AreEqual("9", SumStrings.StringsSum("9", ""));
            Assert.AreEqual("0", SumStrings.StringsSum("", ""));
            Assert.AreEqual("-2", SumStrings.StringsSum("4", "-6"));
            Assert.AreEqual("13", SumStrings.StringsSum("23", "-10"));
            Assert.AreEqual("44", SumStrings.StringsSum("4", "40"));
            Assert.AreEqual("4", SumStrings.StringsSum("4", ""));
            Assert.AreEqual("-7", SumStrings.StringsSum("", "-7"));
        }

        private static string Solve(string s1, string s2)
        {
            int num1 = s1 == "" ? 0 : int.Parse(s1);
            int num2 = s2 == "" ? 0 : int.Parse(s2);
            return (num1 + num2).ToString();
        }

        private static void Act(string s1, string s2)
        {
            var actual = SumStrings.StringsSum(s1, s2);
            var expected = Solve(s1, s2);
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Random Tests")]
        public void RandomTests()
        {
            var rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                string s1, s2;
                switch (rand.Next(4))
                {
                    case 0:
                        s1 = rand.Next(-100, 101).ToString();
                        s2 = "";
                        break;
                    case 1:
                        s1 = "";
                        s2 = rand.Next(-100, 101).ToString();
                        break;
                    case 2:
                        s1 = "";
                        s2 = "";
                        break;
                    default:
                        s1 = rand.Next(-100, 101).ToString();
                        s2 = rand.Next(-100, 101).ToString();
                        break;
                }

                Act(s1, s2);
            }
        }
    }
}