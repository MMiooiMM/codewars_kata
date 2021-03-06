﻿using Kata._5kyu;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class _5kyu_Test
    {
        [TestMethod]
        public void RGB_To_Hex_Conversion_Test()
        {
            Assert.AreEqual("FFFFFF", RGB_To_Hex_Conversion.Rgb(255, 255, 255));
            Assert.AreEqual("FFFFFF", RGB_To_Hex_Conversion.Rgb(255, 255, 300));
            Assert.AreEqual("000000", RGB_To_Hex_Conversion.Rgb(0, 0, 0));
            Assert.AreEqual("9400D3", RGB_To_Hex_Conversion.Rgb(148, 0, 211));
            Assert.AreEqual("9400D3", RGB_To_Hex_Conversion.Rgb(148, -20, 211));
            Assert.AreEqual("90C3D4", RGB_To_Hex_Conversion.Rgb(144, 195, 212));
            Assert.AreEqual("D4350C", RGB_To_Hex_Conversion.Rgb(212, 53, 12));
        }

        [TestMethod]
        public void Weight_for_weight_Test()
        {
            Assert.AreEqual("2000 103 123 4444 99", Weight_for_weight.orderWeight("103 123 4444 99 2000"));
            Assert.AreEqual("11 11 2000 10003 22 123 1234000 44444444 9999", Weight_for_weight.orderWeight("2000 10003 1234000 44444444 9999 11 11 22 123"));
        }

        [TestMethod]
        public void Decimal_to_Factorial_and_Back_Test()
        {
            Assert.AreEqual("341010", Decimal_to_Factorial_and_Back.dec2FactString(463));
            Assert.AreEqual(463, Decimal_to_Factorial_and_Back.factString2Dec("341010"));
        }

        [TestMethod]
        public void Common_Denominators_Test()
        {
            Assert.AreEqual("(6,12)(4,12)(3,12)", Common_Denominators.convertFrac(new long[,] { { 1, 2 }, { 1, 3 }, { 1, 4 } }));
        }

        [TestMethod]
        public void Primes_in_numbers_Test()
        {
            Assert.AreEqual("(2**5)(5)(7**2)(11)", Primes_in_numbers.factors(86240));
            Assert.AreEqual("(2**2)(3**3)(5)(7)(11**2)(17)", Primes_in_numbers.factors(7775460));
        }

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

        [TestMethod]
        public void Car_Park_Escape_Test()
        {
            int[,] carpark = new int[,] { { 1, 0, 0, 0, 2 },
                                          { 0, 0, 0, 0, 0 } };
            string[] result = new string[] { "L4", "D1", "R4" };
            Assert.AreEqual(true, TestHelper.ArrayAreEqual(result, Car_Park_Escape.escape(carpark)));

            carpark = new int[,] { { 2, 0, 0, 1, 0 },
                                          { 0, 0, 0, 1, 0 },
                                          { 0, 0, 0, 0, 0 } };
            result = new string[] { "R3", "D2", "R1" };
            Assert.AreEqual(true, TestHelper.ArrayAreEqual(result, Car_Park_Escape.escape(carpark)));

            carpark = new int[,] { { 0, 2, 0, 0, 1 },
                                          { 0, 0, 0, 0, 1 },
                                          { 0, 0, 0, 0, 1 },
                                          { 0, 0, 0, 0, 0 } };
            result = new string[] { "R3", "D3" };
            Assert.AreEqual(true, TestHelper.ArrayAreEqual(result, Car_Park_Escape.escape(carpark)));

            carpark = new int[,] { { 1, 0, 0, 0, 2 },
                                          { 0, 0, 0, 0, 1 },
                                          { 1, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0 } };
            result = new string[] { "L4", "D1", "R4", "D1", "L4", "D1", "R4" };
            Assert.AreEqual(true, TestHelper.ArrayAreEqual(result, Car_Park_Escape.escape(carpark)));

            carpark = new int[,] { { 0, 0, 0, 0, 2 } };
            result = new string[] { };
            Assert.AreEqual(true, TestHelper.ArrayAreEqual(result, Car_Park_Escape.escape(carpark)));
        }
    }
}