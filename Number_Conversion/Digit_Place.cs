using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Conversion
{
    class Digit_Place
    {
        int multiplier = 0;
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
        
    }
}
