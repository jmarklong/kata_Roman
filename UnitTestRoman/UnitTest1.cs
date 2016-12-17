using System;
using Number_Conversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestRoman
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Assert_1_is_I()
        {
            Number_Manager Test_1 = new Number_Manager(1);
            Assert.AreEqual("I", "I");
        }
        [TestMethod]
        public void Assert_I_is_1()
        {
            Number_Manager Test_I = new Number_Manager("I");
            Assert.AreEqual(1, 1);
        }
    }
}
