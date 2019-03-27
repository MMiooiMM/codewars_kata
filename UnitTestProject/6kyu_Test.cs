using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata._6kyu;

namespace UnitTestProject
{
    [TestClass]
    public class _6kyu_Test
    {

        [TestMethod]
        public void Are_they_the_same_Test()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            var actual = Are_they_the_same.comp(a, b); // True
            var expected = true;
            Assert.AreEqual(expected, actual);
        }
    }
}
