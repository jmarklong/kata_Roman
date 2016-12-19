using System;
using Number_Conversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestRoman
{
    [TestClass]
    public class TestErrorHandling
    {
        private Number_Manager MyNumber = new Number_Manager(0);
        private string RomanReturned = null;
        private int ArabicReturned = 0;

        [TestMethod]
        public void NegativeValues_dont_convert()
        {
            RomanReturned = MyNumber.ToRoman(-1);
            Assert.AreEqual("No Roman Equivalent", MyNumber.Status());
        }
        [TestMethod]
        public void LargeValues_say_OutOfRange()
        {
            RomanReturned = MyNumber.ToRoman(32767);
            Assert.AreEqual("Out of Suported Roman Range", MyNumber.Status());
        }
        [TestMethod]
        public void GarbageIn_IsDetected()
        {
            ArabicReturned = MyNumber.ToArabic("IDKXXIII");
            Assert.AreEqual("Can't convert to Arabic", MyNumber.Status());
        }
        [TestMethod]
        public void ErrorText_is_diagnostic()
        {
            ArabicReturned = MyNumber.ToArabic("IDKXLXXIIBC");
            Assert.AreEqual("Could not translate I-KX--BC", MyNumber.Error_text());
        }

    }
}
