using System;
using System.Linq;
using System.Collections.Generic;

namespace Lecture1_CSharp {
    public class DeleteDuplicateConstantSpace {

        public static void Run(int[] a)
        {
            int i, j;
            int copyAt = 1; //first element is unique by definition
            for (i = 1; i < a.Length; i++) {
                for (j = 0; j < copyAt; j++) { //see if we have already seen this element before?
                    if (a[i] == a[j])
                        break;
                }
                //copy only if we haven't seen.
                if (j == copyAt)
                    a[copyAt++] = a[i]; //note that you are copy a[i]
            }

            Console.WriteLine(string.Join(",", a.Take<int>(copyAt)));
        }

    }

}
