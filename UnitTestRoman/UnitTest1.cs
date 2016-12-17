using System;
using Number_Conversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestRoman
{
    [TestClass]
    public class UnitTest1
    {
        private Number_Manager MyNumber = new Number_Manager(0);
        /// <summary>
        /// These are the tests going from Arabic to Roman
        /// </summary>
        [TestMethod]
        public void Assert_1_is_I()
        {
            Assert.AreEqual("I", MyNumber.ToRoman(1));
        }
        [TestMethod]
        public void Assert_2_is_II()
        {
            Assert.AreEqual("II", MyNumber.ToRoman(2));
        }
        [TestMethod]
        public void Assert_3_is_III()
        {
            Assert.AreEqual("III", MyNumber.ToRoman(3));
        }
        [TestMethod]
        public void Assert_4_is_IV()
        {
            Assert.AreEqual("IV", MyNumber.ToRoman(4));
        }
        [TestMethod]
        public void Assert_5_is_V()
        {
            Assert.AreEqual("V", MyNumber.ToRoman(5));
        }
        [TestMethod]
        public void Assert_6_is_VI()
        {
            Assert.AreEqual("VI", MyNumber.ToRoman(6));
        }
        [TestMethod]
        public void Assert_7_is_VII()
        {
            Assert.AreEqual("VII", MyNumber.ToRoman(7));
        }
        [TestMethod]
        public void Assert_8_is_VIII()
        {
            Assert.AreEqual("VIII", MyNumber.ToRoman(8));
        }
        [TestMethod]
        public void Assert_9_is_IX()
        {
            Assert.AreEqual("IX", MyNumber.ToRoman(9));
        }
        [TestMethod]
        public void Assert_10_is_X()
        {
            Assert.AreEqual("X", MyNumber.ToRoman(10));
        }
        [TestMethod]
        public void Assert_20_is_XX()
        {
            Assert.AreEqual("XX", MyNumber.ToRoman(20));
        }
        [TestMethod]
        public void Assert_30_is_XXX()
        {
            Assert.AreEqual("XXX", MyNumber.ToRoman(30));
        }
        [TestMethod]
        public void Assert_40_is_XL()
        {
            Assert.AreEqual("XL", MyNumber.ToRoman(40));
        }
        [TestMethod]
        public void Assert_50_is_V()
        {
            Assert.AreEqual("L", MyNumber.ToRoman(50));
        }
        [TestMethod]
        public void Assert_60_is_VI()
        {
            Assert.AreEqual("LX", MyNumber.ToRoman(60));
        }
        [TestMethod]
        public void Assert_70_is_VII()
        {
            Assert.AreEqual("LXX", MyNumber.ToRoman(70));
        }
        [TestMethod]
        public void Assert_80_is_VIII()
        {
            Assert.AreEqual("LXXX", MyNumber.ToRoman(80));
        }
        [TestMethod]
        public void Assert_90_is_XC()
        {
            Assert.AreEqual("XC", MyNumber.ToRoman(90));
        }

        /// <summary>
        /// These are the tests going from Roman to Arabic
        /// </summary>
        [TestMethod]
        public void Assert_I_is_1()
        {
            Assert.AreEqual(1, MyNumber.ToArabic("I"));
        }
        [TestMethod]
        public void Assert_II_is_2()
        {
            Assert.AreEqual(2, MyNumber.ToArabic("II"));
        }
        [TestMethod]
        public void Assert_III_is_3()
        {
            Assert.AreEqual(3, MyNumber.ToArabic("III"));
        }
        [TestMethod]
        public void Assert_IV_is_4()
        {
            Assert.AreEqual(4, MyNumber.ToArabic("IV"));
        }
        [TestMethod]
        public void Assert_V_is_V()
        {
            Assert.AreEqual(5, MyNumber.ToArabic("V"));
        }
        [TestMethod]
        public void Assert_VI_is_6()
        {
            Assert.AreEqual(6, MyNumber.ToArabic("VI"));
        }
        [TestMethod]
        public void Assert_VII_is_7()
        {
            Assert.AreEqual(7, MyNumber.ToArabic("VII"));
        }
        [TestMethod]
        public void Assert_VIII_is_8()
        {
            Assert.AreEqual(8, MyNumber.ToArabic("VIII"));
        }
        [TestMethod]
        public void Assert_IX_is_9()
        {
            Assert.AreEqual(9, MyNumber.ToArabic("IX"));
        }
        [TestMethod]
        public void Assert_All_ones_places_convert_to_Roman()
        {
            int[] Expected = new int[9];
            int[] Actual = new int[9];
            for (int i = 1; i < 10; i++)
            {
                Expected[i - 1] = i;
                Actual[i - 1] = MyNumber.ToArabic(MyNumber.ToRoman(i));

            }

            CollectionAssert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void Assert_First100_are_correct()
        {
            int[] Expected = new int[99];
            int[] Actual = new int[99];
            for (int i = 1; i < 100; i++)
            {
                Expected[i - 1] = i;
                Actual[i - 1] = MyNumber.ToArabic(MyNumber.ToRoman(i));
            }
            CollectionAssert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void Assert_First_1000_are_correct()
        {
            int[] Expected = new int[999];
            int[] Actual = new int[999];
            for (int i = 1; i < 1000; i++)
            {
                Expected[i - 1] = i;
                Actual[i - 1] = MyNumber.ToArabic(MyNumber.ToRoman(i));
            }
            CollectionAssert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void Assert_First_4000_are_correct()
        {
            int[] Expected = new int[3999];
            int[] Actual = new int[3999];
            for (int i = 1; i < 4000; i++)
            {
                Expected[i - 1] = i;
                Actual[i - 1] = MyNumber.ToArabic(MyNumber.ToRoman(i));
            }
            CollectionAssert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void Assert_998_is_CMXCVIII()
        {
            Assert.AreEqual(998, MyNumber.ToArabic("CMXCVIII"));
        }
        [TestMethod]
        public void Assert_999_is_CMXCIX()
        {
            Assert.AreEqual(999, MyNumber.ToArabic("CMXCIX"));
        }
        [TestMethod]
        public void Assert_1000_is_M()
        {
            Assert.AreEqual(1000, MyNumber.ToArabic("M"));
        }
        [TestMethod]
        public void Assert_1001_is_MI()
        {
            Assert.AreEqual(1001, MyNumber.ToArabic("MI"));
        }
    }
}
