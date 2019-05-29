using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata._6kyu;

namespace UnitTestProject
{
    [TestClass]
    public class _6kyu_Test
    {
        [TestMethod]
        public void Bit_Counting_Test()
        {
            var actual = Bit_Counting.CountBits(1);
            var expected = 1;
            Assert.AreEqual(actual, expected);

            actual = Bit_Counting.CountBits(2);
            expected = 1;
            Assert.AreEqual(actual, expected);

            actual = Bit_Counting.CountBits(3);
            expected = 2;
            Assert.AreEqual(actual, expected);

            actual = Bit_Counting.CountBits(4);
            expected = 1;
            Assert.AreEqual(actual, expected);

            actual = Bit_Counting.CountBits(1234);
            expected = 5;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Data_Reverse_Test()
        {
            var actual = Data_Reverse.DataReverse(new int[32] { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0 });
            var expected = new int[32] { 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 };
            Assert.IsTrue(TestHelper.ArrayAreEqual(actual, expected));

            actual = Data_Reverse.DataReverse(new int[16] { 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1 });
            expected = new int[16] { 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0 };
            Assert.IsTrue(TestHelper.ArrayAreEqual(actual, expected));
        }

        [TestMethod]
        public void Sum_of_Digits_Digital_Root_Test()
        {
            var actual = Sum_of_Digits_Digital_Root.DigitalRoot(16);
            var expected = 7;
            Assert.AreEqual(actual, expected);

            actual = Sum_of_Digits_Digital_Root.DigitalRoot(942);
            expected = 6;
            Assert.AreEqual(actual, expected);

            actual = Sum_of_Digits_Digital_Root.DigitalRoot(132189);
            expected = 6;
            Assert.AreEqual(actual, expected);

            actual = Sum_of_Digits_Digital_Root.DigitalRoot(493193);
            expected = 2;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Is_a_number_prime_Test()
        {
            Assert.IsFalse(Is_a_number_prime.IsPrime(0));
            Assert.IsFalse(Is_a_number_prime.IsPrime(1));
            Assert.IsTrue(Is_a_number_prime.IsPrime(2));
            Assert.IsTrue(Is_a_number_prime.IsPrime(3));
            Assert.IsFalse(Is_a_number_prime.IsPrime(4));
            Assert.IsTrue(Is_a_number_prime.IsPrime(5));
            Assert.IsFalse(Is_a_number_prime.IsPrime(6));
            Assert.IsTrue(Is_a_number_prime.IsPrime(7));
            Assert.IsFalse(Is_a_number_prime.IsPrime(8));
            Assert.IsFalse(Is_a_number_prime.IsPrime(9));
            Assert.IsTrue(Is_a_number_prime.IsPrime(73));
            Assert.IsFalse(Is_a_number_prime.IsPrime(75));
            Assert.IsTrue(Is_a_number_prime.IsPrime(5099));
            Assert.IsFalse(Is_a_number_prime.IsPrime(-1));
            Assert.IsFalse(Is_a_number_prime.IsPrime(-2));
        }

        [TestMethod]
        public void PI_approximation_Test()
        {
            var actual = PI_approximation.iterPi(0.1);
            var expected = new ArrayList { 10d, 3.0418396189 };
            Assert.IsTrue(TestHelper.ArrayAreEqual(actual, expected));
            
            actual = PI_approximation.iterPi(0.001);
            expected = new ArrayList { 1000d, 3.1405926538 };
            Assert.IsTrue(TestHelper.ArrayAreEqual(actual, expected));
        }

        [TestMethod]
        public void Consonant_value_Test()
        {
            var actual = Consonant_value.Solve("zodiac");
            var expected = 26;
            Assert.AreEqual(expected, actual);

            actual = Consonant_value.Solve("chruschtschov");
            expected = 80;
            Assert.AreEqual(expected, actual);

            actual = Consonant_value.Solve("khrushchev");
            expected = 38;
            Assert.AreEqual(expected, actual);

            actual = Consonant_value.Solve("strength");
            expected = 57;
            Assert.AreEqual(expected, actual);

            actual = Consonant_value.Solve("catchphrase");
            expected = 73;
            Assert.AreEqual(expected, actual);

            actual = Consonant_value.Solve("twelfthstreet");
            expected = 103;
            Assert.AreEqual(expected, actual);

            actual = Consonant_value.Solve("mischtschenkoana");
            expected = 80;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Are_they_the_same_Test()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            var actual = Are_they_the_same.comp(a, b);
            Assert.IsTrue(actual);
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
