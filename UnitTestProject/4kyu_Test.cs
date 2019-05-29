using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata._4kyu;

namespace UnitTestProject
{
    [TestClass]
    public class _4kyu_Test
    {
        [TestMethod]
        public void Range_Extraction_Test()
        {
            var actual = Range_Extraction.Extract(new[] { 1, 2 });
            var expected = "1,2";
            Assert.AreEqual(expected, actual);
            actual = Range_Extraction.Extract(new[] { 1, 2, 3 });
            expected = "1-3";
            Assert.AreEqual(expected, actual);
            actual = Range_Extraction.Extract(new[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 });
            expected = "-6,-3-1,3-5,7-11,14,15,17-20";
            Assert.AreEqual(expected, actual);
            actual = Range_Extraction.Extract(new[] { -3, -2, -1, 2, 10, 15, 16, 18, 19, 20 });
            expected = "-3--1,2,10,15,16,18-20";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Next_smaller_number_with_the_same_digits_Test()
        {
            var actual = Next_smaller_number_with_the_same_digits_Clever.NextSmaller(21);
            var expected = 12;
            Assert.AreEqual(expected, actual);
            actual = Next_smaller_number_with_the_same_digits_Clever.NextSmaller(907);
            expected = 790;
            Assert.AreEqual(expected, actual);
            actual = Next_smaller_number_with_the_same_digits_Clever.NextSmaller(531);
            expected = 513;
            Assert.AreEqual(expected, actual);
            actual = Next_smaller_number_with_the_same_digits_Clever.NextSmaller(1027);
            expected = -1;
            Assert.AreEqual(expected, actual);
            actual = Next_smaller_number_with_the_same_digits_Clever.NextSmaller(441);
            expected = 414;
            Assert.AreEqual(expected, actual);
            actual = Next_smaller_number_with_the_same_digits_Clever.NextSmaller(123456798);
            expected = 123456789;
            Assert.AreEqual(expected, actual);
        }
    }
}
