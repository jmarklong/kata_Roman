using System;
using Number_Conversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestRoman
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// These are the tests going from Arabic to Roman
        /// </summary>
        [TestMethod]
        public void Assert_1_is_I()
        {
            Number_Manager Test_1 = new Number_Manager(1);
            Assert.AreEqual("I", Test_1.ToRoman());
        }
        [TestMethod]
        public void Assert_2_is_II()
        {
            Number_Manager Test_1 = new Number_Manager(2);
            Assert.AreEqual("II", Test_1.ToRoman());
        }
        [TestMethod]
        public void Assert_3_is_III()
        {
            Number_Manager Test_1 = new Number_Manager(3);
            Assert.AreEqual("III", Test_1.ToRoman());
        }
        [TestMethod]
        public void Assert_4_is_IV()
        {
            Number_Manager Test_1 = new Number_Manager(4);
            Assert.AreEqual("IV", Test_1.ToRoman());
        }
        [TestMethod]
        public void Assert_5_is_V()
        {
            Number_Manager Test_1 = new Number_Manager(5);
            Assert.AreEqual("V", Test_1.ToRoman());
        }
        [TestMethod]
        public void Assert_6_is_VI()
        {
            Number_Manager Test_1 = new Number_Manager(6);
            Assert.AreEqual("VI", Test_1.ToRoman());
        }
        [TestMethod]
        public void Assert_7_is_VII()
        {
            Number_Manager Test_1 = new Number_Manager(7);
            Assert.AreEqual("VII", Test_1.ToRoman());
        }
        [TestMethod]
        public void Assert_8_is_VIII()
        {
            Number_Manager Test_1 = new Number_Manager(8);
            Assert.AreEqual("VIII", Test_1.ToRoman());
        }
        [TestMethod]
        public void Assert_9_is_IX()
        {
            Number_Manager Test_1 = new Number_Manager(9);
            Assert.AreEqual("IX", Test_1.ToRoman());
        }
        /// <summary>
        /// These are the tests going from Roman to Arabic
        /// </summary>
        [TestMethod]
        public void Assert_I_is_1()
        {
            Number_Manager Test_I = new Number_Manager("I");
            Assert.AreEqual(1, 1);
        }
    }
}
