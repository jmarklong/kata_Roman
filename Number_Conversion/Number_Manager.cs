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

        public Number_Manager(int Starting_number)
        {
            Arabic = Starting_number;
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
