using System;
using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class FinancingPurchaseTests
    {
        private static void testing(double rate, int bal, int term, int num_payments, string expected)
        {
            string ans = FinancingPurchase.Amort(rate, bal, term, num_payments);
            Console.WriteLine("rate: {0}, bal: {1}, term: {2}, num_payments: {3} expected: {4}",
                rate, bal, term, num_payments, expected);
            Assert.AreEqual(expected, ans);
        }

        [Test]
        public static void test1()
        {
            testing(7.4, 10215, 24, 20, "num_payment 20 c 459 princ 445 int 14 balance 1809");
            testing(7.9, 107090, 48, 41, "num_payment 41 c 2609 princ 2476 int 133 balance 17794");
            testing(6.8, 105097, 36, 4, "num_payment 4 c 3235 princ 2685 int 550 balance 94447");
            testing(3.8, 48603, 24, 10, "num_payment 10 c 2106 princ 2009 int 98 balance 28799");
            testing(1.9, 182840, 48, 18, "num_payment 18 c 3959 princ 3769 int 189 balance 115897");
            testing(1.9, 19121, 48, 2, "num_payment 2 c 414 princ 384 int 30 balance 18353");
            testing(2.2, 112630, 60, 11, "num_payment 11 c 1984 princ 1810 int 174 balance 92897");
            testing(5.6, 133555, 60, 53, "num_payment 53 c 2557 princ 2464 int 93 balance 17571");
            testing(9.8, 67932, 60, 34, "num_payment 34 c 1437 princ 1153 int 283 balance 33532");
            testing(3.7, 64760, 36, 24, "num_payment 24 c 1903 princ 1829 int 75 balance 22389");
        }
    }
}