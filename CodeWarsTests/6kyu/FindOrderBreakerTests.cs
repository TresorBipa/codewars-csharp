using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindOrderBreakerTests
    {
        private List<(List<int>, int)> tests = new List<(List<int>, int)>()
        {
            (new List<int>() {2, 1}, 2),
            (new List<int>() {0, -10}, 0),
            (new List<int>() {15, 0}, 15),
            (new List<int>() {1, 3, 2}, 3),
            (new List<int>() {1, 0, 2}, 1),
            (new List<int>() {1, 2, 0, 3, 4}, 0),
            (new List<int>() {1, 2, 3, 4, -1}, -1),
            (new List<int>() {-11, 5, 0, 3, 4}, 5),
            (new List<int>() {-11, -5, 0, -2, 4}, 0),
            (new List<int>() {5, 7, 6, 8, 9, 10}, 7),
            (new List<int>() {1, 2, 3, 4, 17, 5, 6, 7, 8}, 17),
            (new List<int>() {19, 27, 33, 34, 112, 578, 116, 170, 800}, 578),
            (new List<int>() {105, 110, 111, 112, 114, 113, 115}, 114),
            (new List<int>() {1001, 991, 992, 993, 994, 995, 996}, 1001),
        };

        [Test]
        public void test1()
        {
            foreach (var test in tests)
            {
                Assert.AreEqual(test.Item2, FindOrderBreaker.OrderBreaker(test.Item1.ToArray()));
            }
        }
    }
}