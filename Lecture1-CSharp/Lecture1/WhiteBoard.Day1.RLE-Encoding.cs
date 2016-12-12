using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_CSharp.Lecture1 {
    //this is similar to atoi and itoa functions
    class RleEncoding {

        public static string Decode(string input)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            foreach (var ch in input.ToCharArray()) {
                if (Char.IsDigit(ch)) {
                    count = count * 10 + (ch - '0');
                } else {
                    sb.Append(ch, count);
                    count = 0;
                }
            }
            return sb.ToString();
        }


        public static string Encode(string input)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            char prevChar = input[0];
            for (int i = 0; i < input.Length; i++) {
                if (input[i] != prevChar)
                {
                    sb.AppendFormat($"{count}{prevChar}");
                    prevChar = input[i];
                    count = 1;
                }
                else 
                {
                    ++count;
                }
            }//end of for

            //the last char
            sb.AppendFormat($"{count}{prevChar}");

            return sb.ToString();
        }


    }
}
