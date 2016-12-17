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
        IEnumerable<KeyValuePair<string, int>> LongestStrings = null;
        IEnumerable<KeyValuePair<string, int>> SecondLongestStrings = null;
        IEnumerable<KeyValuePair<string, int>> DoubleStrings = null;
        IEnumerable<KeyValuePair<string, int>> SingleStrings = null;

        public Digit_Place(int power, string units, string units5, string units10)
        {
            multiplier = power;
            Unit_string = units;
            Half_string = units5;
            Ten_string = units10;
            MySubstring = new Dictionary<string, int>();
            MySubstring.Add(Unit_string, 1 * multiplier);
            MySubstring.Add(Unit_string + Unit_string, 2 * multiplier);
            MySubstring.Add(Unit_string + Unit_string + Unit_string, 3 * multiplier);
            MySubstring.Add(Unit_string + Half_string, 4 * multiplier);
            MySubstring.Add(Half_string, 5 * multiplier);
            MySubstring.Add(Half_string + Unit_string, 6 * multiplier);
            MySubstring.Add(Half_string + Unit_string + Unit_string, 7 * multiplier);
            MySubstring.Add(Half_string + Unit_string + Unit_string + Unit_string, 8 * multiplier);
            MySubstring.Add(Unit_string + Ten_string, 9 * multiplier);
            //
            // prepare for pattern matching activity
            //
            LongestStrings = MySubstring.Where(p => p.Value == (3 * multiplier) || p.Value == (8 * multiplier));
            SecondLongestStrings = MySubstring.Where(p => p.Value == (2 * multiplier) || p.Value == (7 * multiplier));
            DoubleStrings = MySubstring.Where(p => p.Value == (4 * multiplier) || p.Value == (9 * multiplier) || p.Value == (6 * multiplier));
            SingleStrings = MySubstring.Where(p => p.Value == (1 * multiplier) || p.Value == (5 * multiplier));
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
            int mod_of_number = number % (multiplier * 10);
            int result = (number % (multiplier * 10)) / multiplier;
            return result;
        }

        public int ToArabic(string RomanNumber, out string RemainderRoman)
        {
            int Check_result = 0;
            int Return_Result = 0;
            string match = "*";
            //
            // have to look for the strings in a particular order, finding the longer strings first, to avoid pulling the string apart incorrectly
            //
            Check_result = CheckForMatch(RomanNumber, LongestStrings);
            if (0 == Check_result)
            {
                Check_result = CheckForMatch(RomanNumber, SecondLongestStrings);
            }
            if (0 == Check_result)
            {
                Check_result = CheckForMatch(RomanNumber, DoubleStrings);
            }
            if (0 == Check_result)
            {
                Check_result = CheckForMatch(RomanNumber, SingleStrings);
            }
            if (0 < Check_result)
            {
                // found a match
                match = MySubstring.Where(p => Check_result == p.Value).SingleOrDefault().Key;
                Return_Result = Check_result;
                RemainderRoman = RomanNumber.Replace(match, "-");
            }
            else
            {
                RemainderRoman = RomanNumber;
            }

            return Return_Result;
        }

        int CheckForMatch(String RomanSt, IEnumerable<KeyValuePair<string, int>> RomanStrings)
        {
            int result = 0;
            foreach (var Substring in RomanStrings)
            {
                if (RomanSt.Contains(Substring.Key)) result = Substring.Value;
            }
            return result;
        }
    }
}
