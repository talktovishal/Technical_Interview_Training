using System;

namespace Lecture1_CSharp {
    public class ThreeSumFast {
        public static void Run(int[] a)
        {
            Array.Sort<int>(a);
            for (int i = 0; i < a.Length; i++) {
                for (int j = i + 1; j < a.Length; j++) {
                    int k = Array.BinarySearch<int>(a, -(a[i] + a[j]));
                    if (k > j)
                        Console.WriteLine(a[i] + "," + a[j] + "," + a[k]);
                }
            }
        }

    }

}
