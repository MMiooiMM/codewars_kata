using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void up_AND_down_Test()
        {
            var a = "after be arrived two My so";
            var actual = up_AND_down.Arrange(a);
            var expected = "be ARRIVED two AFTER my SO";
            Assert.AreEqual(expected, actual);

            a = "who hit retaining The That a we taken";
            actual = up_AND_down.Arrange(a);
            expected = "who RETAINING hit THAT a THE we TAKEN";
            Assert.AreEqual(expected, actual);

            a = "on I came up were so grandmothers";
            actual = up_AND_down.Arrange(a);
            expected = "i CAME on WERE up GRANDMOTHERS so";
            Assert.AreEqual(expected, actual);

            a = "way the my wall them him";
            actual = up_AND_down.Arrange(a);
            expected = "way THE my WALL him THEM";
            Assert.AreEqual(expected, actual);

            a = "turn know great-aunts aunt look A to back";
            actual = up_AND_down.Arrange(a);
            expected = "turn GREAT-AUNTS know AUNT a LOOK to BACK";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void up_AND_down_Linq_Test()
        {
            var a = "after be arrived two My so";
            var actual = up_AND_down.Arrange_Linq(a);
            var expected = "be ARRIVED two AFTER my SO";
            Assert.AreEqual(expected, actual);

            a = "who hit retaining The That a we taken";
            actual = up_AND_down.Arrange_Linq(a);
            expected = "who RETAINING hit THAT a THE we TAKEN";
            Assert.AreEqual(expected, actual);

            a = "on I came up were so grandmothers";
            actual = up_AND_down.Arrange_Linq(a);
            expected = "i CAME on WERE up GRANDMOTHERS so";
            Assert.AreEqual(expected, actual);

            a = "way the my wall them him";
            actual = up_AND_down.Arrange_Linq(a);
            expected = "way THE my WALL him THEM";
            Assert.AreEqual(expected, actual);

            a = "turn know great-aunts aunt look A to back";
            actual = up_AND_down.Arrange_Linq(a);
            expected = "turn GREAT-AUNTS know AUNT a LOOK to BACK";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Integers_Recreation_Two_Test()
        {
            var actual = Integers_Recreation_Two.Prod2Sum(1, 2, 1, 3);
            var expected = new List<long[]>() { new long[] { 1, 7 } , new long[] { 5, 5 } };
            Assert.IsTrue(Integers_Recreation_Two.AreEqual(actual, expected));
            
            actual = Integers_Recreation_Two.Prod2Sum(2, 3, 4, 5);
            expected = new List<long[]>() { new long[] { 2, 23 }, new long[] { 7, 22 } };
            Assert.IsTrue(Integers_Recreation_Two.AreEqual(actual, expected));
        }
    }
}
