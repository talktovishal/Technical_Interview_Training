using System;

namespace Lecture1_CSharp {
    public class ThreeSum {
        public static void Run(int[] a)
        {
            for (int i = 0; i < a.Length; i++) {
                for (int j = i + 1; j < a.Length; j++) {
                    for (int k = j + 1; k < a.Length; k++) {
                        if (a[i] + a[j] + a[k] == 0) {
                            Console.WriteLine(a[i] + "," + a[j] + "," + a[k]);
                        }
                    }
                }
            }
        }

    }

}
