using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Conversion
{
    public class Number_Manager
    {
        NumberValue MyValue = new NumberValue();
        Digit_Place Ones_place = new Digit_Place(1, "I", "V", "X");
        Digit_Place Tens_place = new Digit_Place(10, "X", "L", "C");
        Digit_Place Hundreds_place = new Digit_Place(100, "C", "D", "M");
        Digit_Place Thousands_place = new Digit_Place(1000, "M", "_v", "_x");

        public Number_Manager(int Starting_number)
        {
            MyValue.Arabic = Starting_number;
            ComputeRoman();
        }
        
        public Number_Manager(string Starting_number)
        {
            MyValue.Roman = Starting_number;
            ComputeArabic();
        }
        
        public int ToArabic()
        {
            return MyValue.Arabic;
        }
        /// <summary>
        /// ToArabic with a string parameter will reset the value of the class
        /// </summary>
        /// <param name="a_Roman"></param>
        /// <returns></returns>
        public int ToArabic(string a_Roman)
        {
            MyValue.Roman = a_Roman;
            ComputeArabic();

            return ToArabic();
        }

        public string ToRoman()
        {
            return MyValue.Roman;
        }

        public string ToRoman(int an_Arabic)
        {
            MyValue.Arabic = an_Arabic;
            ComputeRoman();
            return ToRoman();
        }

        private void ComputeRoman()
        {
            if (MyValue.Arabic < 0)
            {
                MyValue.Roman = "";
                MyValue.Status = "No Roman Equivalent";
                MyValue.Error_text = "Roman numerals can not be negative";
            }
            else if (MyValue.Arabic > 4000)
            {
                MyValue.Roman = "";
                MyValue.Status = "Out of Supported Roman Range";
                MyValue.Error_text = "Only Roman numerals between 1 and 4000 are supported";
            }
            else
            {
                MyValue.Roman = Thousands_place.ToRoman(MyValue.Arabic) 
                            + Hundreds_place.ToRoman(MyValue.Arabic) 
                            + Tens_place.ToRoman(MyValue.Arabic) 
                            + Ones_place.ToRoman(MyValue.Arabic);
                MyValue.Status = "Success converting to Roman numeral expresson";
                MyValue.Error_text = "";
            }
        }

        private void ComputeArabic()
        {
            MyValue.Arabic = Ones_place.ToArabic(MyValue.Roman, out string Remainder_without_ones);
            MyValue.Arabic += Tens_place.ToArabic(Remainder_without_ones, out string Remainder_without_tens);
            MyValue.Arabic += Hundreds_place.ToArabic(Remainder_without_tens, out string Remainder_without_hundreds);
            MyValue.Arabic += Thousands_place.ToArabic(Remainder_without_hundreds, out string Remainder_without_thousands);
            if (Remainder_without_thousands.Length != Remainder_without_thousands.Count(c => c == '-'))
            {
                // this means we have some characters that did not translate
                MyValue.Status = "Can't convert to Arabic";
                MyValue.Error_text = "Could not translate " + Remainder_without_thousands;
            }
            else
            {
                // we did get a good translation
                MyValue.Status = "Success converting to Arabic numeral expression";
                MyValue.Error_text = "";
            }
        }

        public string Status()
        {
            return MyValue.Status;
        }
        
        public string Error_text()
        {
            return MyValue.Error_text;
        }
    } 
}
