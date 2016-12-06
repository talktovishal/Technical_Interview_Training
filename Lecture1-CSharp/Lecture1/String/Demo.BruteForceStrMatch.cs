using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_CSharp.Lecture1.String {
    class BruteForceStrMatch {


        public static int Search(string pattern, string text)
        {
            int M = pattern.Length;
            int N = text.Length;
            for (int i = 0; i <= N - M; i++) {
                int j;
                for (j = 0; j < M; j++)
                    if (text[i + j] != pattern[j])
                        break;
                //index in N where patterntern was found
                if (j == M) return i;
            }

            //not found
            return N;
        }



        public static int ExplicitBackTrack(string pattern, string text)
        {
            int i, N = text.Length;
            int j, M = pattern.Length;
            for (i = 0, j = 0; i < N && j < M; i++) {
                if (text[i] == pattern[j]) j++;
                //this is where backtracking happens
                else { i -= j; j = 0; }
            }
            if (j == M) return i - M;
            else return N;
        }

        /*
        


Value =
The length of the longest proper prefix in the (sub)pattern that matches 
a proper suffix in the same (sub)pattern.

It gives us: 
How much to skip i.e. where do we start the next comparison in the pattern?

*/


    }
}
