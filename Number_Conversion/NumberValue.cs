using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Conversion
{
    public class NumberValue
    {
        public int Arabic { get; set; }
        public string Roman { get; set; }
        public string Status { get; set; }
        public string Error_text { get; set; }

        public NumberValue()
        {
            Arabic = 0;
            Roman = "";
            Status = "Initialized";
            Error_text = "";
        }
    }
}
