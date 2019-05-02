using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata._5kyu;

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
    }
}
