using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3 {
    public class StringHelper {
        public string ReverseString(string str) {
            if (str == null || str.Length == 0) return ""; 
            char[] temp = str.ToCharArray();
            Array.Reverse(temp);
            var reversedString = new string(temp);
            return reversedString;
        }
    }
}
