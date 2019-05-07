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
    }
}
