using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Conversion
{
    class Digit_Place
    {
        int multiplier;
        string Unit_string = "";
        string Half_string = "";
        string Ten_string = "";
        Dictionary<string, int> MySubstring = null;

        public Digit_Place(int power, string units, string units5, string units10)
        {
            multiplier = power;
            Unit_string = units;
            Half_string = units5;
            Ten_string = units10;
        }

        public string ToRoman(int SingleDigit)
        {
            string StartWith = null;
            string Max = null;
            string result = "";
            int MyDigit = aDigit(SingleDigit);
            if (5 > MyDigit && 0 <= MyDigit)
            {
                StartWith = "";
                Max = Half_string;
            }
            else if (MyDigit > 4 && MyDigit < 10)
            {
                StartWith = Half_string;
                Max = Ten_string;
            }
            int Mod_units = MyDigit % 5;
            if (Mod_units < 4)
            {
                result = StartWith;
                for (int counter = 1; counter <= Mod_units; counter++)
                {
                    result = result + Unit_string;
                }
            }
            else if (4 == Mod_units)
            {
                result = Unit_string + Max;
            }
            return result;
        }

        int aDigit(int number)
        {
            //int result = 0;
            int mod_of_number = number % (multiplier * 10);
            int result2 = (number % (multiplier * 10)) / multiplier;
            //int div_of_number = number / multiplier;
            //int first = (number % multiplier) / multiplier;
            //int second = ((number / (10 * multiplier)) * multiplier);
            //result = div_of_number - second;
            return result2;
        }

    }
}
