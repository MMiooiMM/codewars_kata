using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata._5kyu;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class _5kyu_Test
    {
        [TestMethod]
        public void Simple_Fun_Runners_Meetings_Test()
        {
            Assert.AreEqual(3, Simple_Fun_Runners_Meetings.RunnersMeetings(new int[] { 1, 4, 2 }, new int[] { 27, 18, 24 }));
            Assert.AreEqual(2, Simple_Fun_Runners_Meetings.RunnersMeetings(new int[] { 1, 4, 2 }, new int[] { 5, 6, 2 }));
            Assert.AreEqual(-1, Simple_Fun_Runners_Meetings.RunnersMeetings(new int[] { 1, 2, 3 }, new int[] { 1, 1, 1 }));
            Assert.AreEqual(2, Simple_Fun_Runners_Meetings.RunnersMeetings(new int[] { 1, 1000 }, new int[] { 23, 22 }));
        }

        [TestMethod]
        public void Best_travel_Test()
        {
            List<int> ts = new List<int> { 50, 55, 56, 57, 58 };
            int? n = Best_travel.chooseBestSum(163, 3, ts);
            Assert.AreEqual(163, n);

            ts = new List<int> { 50 };
            n = Best_travel.chooseBestSum(163, 3, ts);
            Assert.AreEqual(null, n);

            ts = new List<int> { 91, 74, 73, 85, 73, 81, 87 };
            n = Best_travel.chooseBestSum(230, 3, ts);
            Assert.AreEqual(228, n);
        }

        [TestMethod]
        public void K_Primes_Test()
        {
            var actual = K_Primes.CountKprimes(2, 0, 100);
            var expected = new long[]
                {4, 6, 9, 10, 14, 15, 21, 22, 25, 26, 33, 34, 35, 38, 39, 46, 49, 51,
                 55, 57, 58, 62, 65, 69, 74, 77, 82, 85, 86, 87, 91, 93, 94, 95};
            Assert.AreEqual(TestHelper.ArrayToString(expected), TestHelper.ArrayToString(actual));

            actual = K_Primes.CountKprimes(3, 0, 100);
            expected = new long[]
                {8, 12, 18, 20, 27, 28, 30, 42, 44, 45, 50, 52, 63, 66, 68, 70, 75, 76,
                 78, 92, 98, 99};
            Assert.AreEqual(TestHelper.ArrayToString(expected), TestHelper.ArrayToString(actual));

            actual = K_Primes.CountKprimes(5, 1000, 1100);
            expected = new long[]
                {1020, 1026, 1032, 1044, 1050, 1053, 1064, 1072, 1092, 1100};
            Assert.AreEqual(TestHelper.ArrayToString(expected), TestHelper.ArrayToString(actual));

            actual = K_Primes.CountKprimes(5, 500, 600);
            expected = new long[]
                {500, 520, 552, 567, 588, 592, 594};
            Assert.AreEqual(TestHelper.ArrayToString(expected), TestHelper.ArrayToString(actual));
        }
    }
}
