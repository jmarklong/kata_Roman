using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Conversion
{
    public class Number_Manager
    {
        int Arabic = 0;
        string Roman = "";
        Digit_Place Ones_place = new Digit_Place(1, "I", "V", "X");
        Digit_Place Tens_place = new Digit_Place(10, "X", "L", "C");
        Digit_Place Hundreds_place = new Digit_Place(100, "C", "D", "M");
        Digit_Place Thousands_place = new Digit_Place(1000, "M", "_v", "_x");

        public Number_Manager(int Starting_number)
        {
            Arabic = Starting_number;
            Roman = Thousands_place.ToRoman(Arabic) +
                Hundreds_place.ToRoman(Arabic) + Tens_place.ToRoman(Arabic) + Ones_place.ToRoman(Arabic);
        }

        public Number_Manager(string Starting_number)
        {
            Roman = Starting_number;
            Arabic = Ones_place.ToArabic(Roman, out string Remainder_without_ones);
            Arabic += Tens_place.ToArabic(Remainder_without_ones, out string Remainder_without_tens);
            Arabic += Hundreds_place.ToArabic(Remainder_without_tens, out string Remainder_without_hundreds);
            Arabic += Thousands_place.ToArabic(Remainder_without_hundreds, out string Remainder_without_thousands);
        }

        public int ToArabic()
        {
            return Arabic;
        }
        /// <summary>
        /// ToArabic with a string parameter will reset the value of the class
        /// </summary>
        /// <param name="a_Roman"></param>
        /// <returns></returns>
        public int ToArabic(string a_Roman)
        {
            Roman = a_Roman;
            Arabic = Ones_place.ToArabic(Roman, out string Remainder_without_ones);
            Arabic += Tens_place.ToArabic(Remainder_without_ones, out string Remainder_without_tens);
            Arabic += Hundreds_place.ToArabic(Remainder_without_tens, out string Remainder_without_hundreds);
            Arabic += Thousands_place.ToArabic(Remainder_without_hundreds, out string Remainder_without_thousands);

            return ToArabic();
        }

        public string ToRoman()
        {
            return Roman;
        }

        public string ToRoman(int an_Arabic)
        {
            Arabic = an_Arabic;
            Roman = Thousands_place.ToRoman(Arabic) +
                Hundreds_place.ToRoman(Arabic) + Tens_place.ToRoman(Arabic) + Ones_place.ToRoman(Arabic);
            return ToRoman();
        }
    }
    
    
}
