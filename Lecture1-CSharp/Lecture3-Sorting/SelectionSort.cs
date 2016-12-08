using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_CSharp.Lecture3_Sorting {
    class SelectionSort {


        public static void Run(int[] a)
        {
            int n = a.Length;
            List<int> index = new List<int>();
            for (int i = 0; i < n; i++) {
                index.Add(i);
            }
            Console.WriteLine(string.Join(" | ", index));

            for (int i = 0; i < n; i++) {
                Console.WriteLine(string.Join(" | ", a));

                int iMax = 0; //start with 0
                //find the max element in the "remaining" array
                for (int j = 0; j < n - i; j++) {
                    if (a[j] > a[iMax]) {
                        iMax = j;
                    }
                }
                int currentLargestIndex = n - 1 - i;
                Console.WriteLine($"{iMax} <> {currentLargestIndex}");
                //pay attention to n-i, n-i-1.
                int temp = a[currentLargestIndex];
                a[currentLargestIndex] = a[iMax];
                a[iMax] = temp;
            }
        }


    }
}
