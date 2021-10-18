using System;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataCheckExamTests
    {
        [TestCase(new string[] { "a", "a", "b", "b" }, new string[] { "a", "c", "b", "d" }, 6)]
        [TestCase(new string[] { "a", "a", "c", "b" }, new string[] { "a", "a", "b", "" }, 7)]
        [TestCase(new string[] { "a", "a", "b", "c" }, new string[] { "a", "a", "b", "c" }, 16)]
        [TestCase(new string[] { "b", "c", "b", "a" }, new string[] { "", "a", "a", "c" }, 0)]
        [TestCase(new string[] { "a", "c", "b", "d" }, new string[] { "", "", "", "" }, 0)]
        public void SampleTest(string[] arr1, string[] arr2, int score)
        {
            Assert.AreEqual(score, KataCheckExam.CheckExam(arr1, arr2));
        }

        // [TestCase(new string[] { "a", "a", "a", "a", "a" }, new string[] { "a", "a", "a", "a", "a" }, null)]
        // [TestCase(new string[] { "b", "b", "b" }, new string[] { "b", "b", "b" }, null)]
        // public void LengthParamsTests(string[] arr1, string[] arr2, int score)
        // {
        //     Assert.AreEqual(score, KataCheckExam.CheckExam(arr1, arr2));
        //     Assert.AreEqual(score, KataCheckExam.CheckExam(arr1, arr2));
        // }

        [Test]
        public void RandomTests1()
        {
            var letsAnswers = new string[] { "a", "b", "c", "d" };
            var letsStudent = new string[] { "a", "b", "c", "d", "" };

            for (int i = 0; i <= 100; i++)
            {
                string[] rndAnswers = new string[letsAnswers.Length];
                string[] rndStudent = new string[letsAnswers.Length];

                for (int j = 0; j < letsAnswers.Length; j++)
                {
                    rndAnswers[j] = letsAnswers[Rnd.Next(0, letsAnswers.Length)];
                    rndStudent[j] = letsStudent[Rnd.Next(0, letsStudent.Length)];
                }

                int expected = Solution(rndAnswers, rndStudent);
                string message = FailureMessage(rndAnswers, rndStudent, expected);
                int actual = KataCheckExam.CheckExam(rndAnswers, rndStudent);
                // Console.WriteLine(message);
                Assert.AreEqual(expected, actual, message);
            }
        }

        [Test]
        public void RandomTests2()
        {
            var letsAnswers = new string[] { "a", "b", "c", "d" };
            var letsStudent = new string[] { "a", "b", "c", "d", "" };

            for (int i = 0; i <= 100; i++)
            {
                int arrLength = Rnd.Next(4, 20);
                string[] rndAnswers = new string[arrLength];
                string[] rndStudent = new string[arrLength];

                for (int j = 0; j < arrLength; j++)
                {
                    rndAnswers[j] = letsAnswers[Rnd.Next(0, letsAnswers.Length)];
                    rndStudent[j] = letsStudent[Rnd.Next(0, letsStudent.Length)];
                }

                int expected = Solution(rndAnswers, rndStudent);
                string message = FailureMessage(rndAnswers, rndStudent, expected);
                int actual = KataCheckExam.CheckExam(rndAnswers, rndStudent);
                // Console.WriteLine(message);

                Assert.AreEqual(expected, actual, message);
            }
        }

        private static string FailureMessage(string[] answers, string[] student, int value)
        {
            var joinAnswers = string.Join(", ", answers.Select(x => $"\"{x}\""));
            var joinStudent = string.Join(", ", student.Select(x => $"\"{x}\""));
            var result = $"Should return {value} with [{joinAnswers}] and [{joinStudent}]";
            return result;
        }

        private static readonly Random Rnd = new Random();

        private static int Solution(string[] arr1, string[] arr2)
        {
            int sum = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr1[i] == arr2[i])
                    sum += 4;
                else if (arr2[i] == "")
                    sum += 0;
                else
                    sum += -1;
            }

            return sum > 0 ? sum : 0;
        }
    }
}