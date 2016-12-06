using System;
using System.Collections.Generic;

namespace Lecture1_CSharp {
    public class DeleteDuplicateExtraSpace {
        public static void Run(int[] a)
        {
            HashSet<int> seen = new HashSet<int>();
            List<int> b = new List<int>();
            for (int i = 0; i < a.Length; i++) {
                if(!seen.Contains(a[i])) {
                    seen.Add(a[i]);
                    b.Add(a[i]);
                }
            }
            Console.WriteLine(string.Join(",", b));
        }

    }

}
