using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirror_numbers
{
    public class callculate_is_mirror
    {
        public static bool callculate(int number)
        {
            string numberString=number.ToString();
            char[] chars=numberString.ToCharArray();
            Array.Reverse(chars);
            string reverseNumberString = new string(chars);
            return numberString == reverseNumberString;
        }
    }
}
