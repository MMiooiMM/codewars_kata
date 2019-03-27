using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata._4kyu;

namespace UnitTestProject
{
    [TestClass]
    public class _4kyu_Test
    {

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
