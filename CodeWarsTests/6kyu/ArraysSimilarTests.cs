using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataArraysSimilarTests
    {
        [Test]
        public void BasicTest1()
        {
            Assert.AreEqual(true, KataArraysSimilar.ArraysSimilar(new object[] { }, new object[] { }),
                "Should return true with [] and []");

            Assert.AreEqual(true, KataArraysSimilar.ArraysSimilar(new object[] { 1, 2 }, new object[] { 2, 1 }),
                "Should return true with [1, 2] and [2, 1]");

            Assert.AreEqual(true, KataArraysSimilar.ArraysSimilar(new object[] { "1", "2" }, new object[] { "2", "1" }),
                "Should return true with [\"1\", \"2\"] and [\"2\", \"1\"]");

            Assert.AreEqual(true, KataArraysSimilar.ArraysSimilar(new object[] { '1', '2' }, new object[] { '2', '1' }),
                "Should return true with ['1', '2'] and ['2', '1']");

            Assert.AreEqual(false, KataArraysSimilar.ArraysSimilar(new object[] { 1, 2 }, new object[] { "1", 2 }),
                "Should return false with [1, 2] and [\"1\", 2]");

            Assert.AreEqual(false, KataArraysSimilar.ArraysSimilar(new object[] { 1, 2 }, new object[] { '1', 2 }),
                "Should return false with [1, 2] and ['1', 2]");

            Assert.AreEqual(false, KataArraysSimilar.ArraysSimilar(new object[] { '1', 2 }, new object[] { "1", 2 }),
                "Should return false with ['1', 2] and [\"1\", 2]");
        }

        [Test]
        public void BasicTest2()
        {
            object[] arr1 = { 1, 2, 2, 3, 4 },
                arr2 = { 2, 1, 2, 4, 3 },
                arr3 = { 1, 1, 2 },
                arr4 = { 4, 3, 2, 1, 1 },
                arr5 = { 1, 2, 2, 3 },
                arr6 = { 3, 3, 2, 1 },
                arr7 = { 1, 2 },
                arr8 = { "1", 2 },
                arr9 = { 5, '3', 1, 2, 4 },
                arr10 = { 2, 4, 5, "3", 1 },
                arr11 = { 1, 2, 3, 4, 5 },
                arr12 = { 5, '4', 3, "2", 1 },
                arr13 = { '3', '5', '4', "1", 2 },
                arr14 = { "1", 2, '3', '4', '5' },
                arr15 = { };

            Assert.AreEqual(true, KataArraysSimilar.ArraysSimilar(arr1, arr2),
                "Should return true with [1, 2, 2, 3, 4] and [2, 1, 2, 4, 3]");

            Assert.AreEqual(true, KataArraysSimilar.ArraysSimilar(arr2, arr1),
                "Should return true with [2, 1, 2, 4, 3] and [1, 2, 2, 3, 4]");

            Assert.AreEqual(false, KataArraysSimilar.ArraysSimilar(arr2, arr3),
                "Should return false with [2, 1, 2, 4, 3] and [1, 1, 2]");

            Assert.AreEqual(false, KataArraysSimilar.ArraysSimilar(arr3, arr4),
                "Should return false with [1, 1, 2] and [4, 3, 2, 1, 1]");

            Assert.AreEqual(false, KataArraysSimilar.ArraysSimilar(arr5, arr6),
                "Should return false with [1, 2, 2, 3] and [3, 3, 2, 1]");

            Assert.AreEqual(false, KataArraysSimilar.ArraysSimilar(arr7, arr8),
                "Should return false with [1, 2] and [\"1\", 2]");

            Assert.AreEqual(false, KataArraysSimilar.ArraysSimilar(arr9, arr10),
                "Should return false with [5, '3', 1, 2, 4] and [2, 4, 5, \"3\", 1]");

            Assert.AreEqual(false, KataArraysSimilar.ArraysSimilar(arr11, arr12),
                "Should return false with [1, 2, 3, 4, 5] and [5, '4', 3, \"2\", 1]");

            Assert.AreEqual(false, KataArraysSimilar.ArraysSimilar(arr9, arr12),
                "Should return false with [5, '3', 1, 2, 4] and [5, '4', 3, \"2\", 1]");

            Assert.AreEqual(false, KataArraysSimilar.ArraysSimilar(arr2, arr11),
                "Should return false with [2, 1, 2, 4, 3] and [5, '4', 3, \"2\", 1]");

            Assert.AreEqual(false, KataArraysSimilar.ArraysSimilar(arr11, arr13),
                "Should return false with [1, 2, 3, 4, 5] and ['3', '5', '4', \"1\", 2]");

            Assert.AreEqual(true, KataArraysSimilar.ArraysSimilar(arr13, arr14),
                "Should return true with ['3', '5', '4', \"1\", 2] and [\"1\", 2, '3', '4', '5']");

            Assert.AreEqual(false, KataArraysSimilar.ArraysSimilar(arr11, arr14),
                "Should return false with [1, 2, 3, 4, 5] and [\"1\", 2, '3', '4', '5']");

            Assert.AreEqual(false, KataArraysSimilar.ArraysSimilar(arr7, arr15),
                "Should return false with [1, 2] and []");
        }

        private static bool Solution(object[] arr1, object[] arr2)
        {
            if (arr1.Length != arr2.Length) return false;

            var seq1 = arr1.OrderBy(x => x.ToString());
            var seq2 = arr2.OrderBy(x => x.ToString());

            return seq1.Zip(seq2, (x, y) => x.Equals(y)).All(x => x);
        }

        private static readonly Random Random = new Random();

        private static object[] RandomObjects(int len)
        {
            object[] numberChars = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var obj = Enumerable.Repeat(numberChars, len)
                .Select(x => x.Select(c =>
                {
                    return Random.Next(1, 4) switch
                    {
                        1 => int.Parse(c.ToString() ?? "1"),
                        2 => c.ToString(),
                        _ => c
                    };
                }).ToArray()).ToArray().Select(s => s[Random.Next(s.Length)]).ToArray();

            return obj;
        }

        private static string FailureMessage(object[] arr1, object[] arr2, bool value)
        {
            string GenArray(object[] arr) => string.Join(", ", arr.Select(c =>
            {
                return c switch
                {
                    int _ => c,
                    string _ => $"\"{c}\"",
                    char _ => $"\'{c}\'",
                    _ => $"`{c}`" // Unknown type - error
                };
            }));

            var a1 = GenArray(arr1);
            var a2 = GenArray(arr2);
            var result = $"Should return {value} with [{a1}] and [{a2}]";
            return result;
        }

        [Test]
        public void RandomTest1()
        {
            for (var i = 0; i < 100; i++)
            {
                object[] arr1 = RandomObjects(3);
                object[] arr2 = RandomObjects(3);

                bool expected = Solution(arr1, arr2);
                string message = FailureMessage(arr1, arr2, expected);
                bool actual = KataArraysSimilar.ArraysSimilar(arr1, arr2);

                Assert.AreEqual(expected, actual, message);
            }
        }

        [Test]
        public void RandomTest2()
        {
            for (var i = 0; i < 100; i++)
            {
                object[] arr1 = RandomObjects(3);
                object[] arr2 = arr1.Reverse().ToArray();

                bool expected = Solution(arr1, arr2);
                string message = FailureMessage(arr1, arr2, expected);
                bool actual = KataArraysSimilar.ArraysSimilar(arr1, arr2);

                Assert.AreEqual(expected, actual, message);
            }
        }

        [Test]
        public void RandomTest3()
        {
            for (var i = 0; i < 100; i++)
            {
                object[] arr1 = RandomObjects(Random.Next(3));
                object[] arr2 = RandomObjects(Random.Next(3));

                bool expected = Solution(arr1, arr2);
                string message = FailureMessage(arr1, arr2, expected);
                bool actual = KataArraysSimilar.ArraysSimilar(arr1, arr2);

                Assert.AreEqual(expected, actual, message);
            }
        }
    }
}


