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

        public Number_Manager(int Starting_number)
        {
            Arabic = Starting_number;
            Roman = Ones_place.ToRoman(Arabic);
        }

        public Number_Manager(string Starting_number)
        {
            Roman = Starting_number;
        }

        public int ToArabic()
        {
            return Arabic;
        }

        public string ToRoman()
        {
            return Roman;
        }

    }
    
    
}
