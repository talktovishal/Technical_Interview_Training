using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_CSharp.Lecture3_Sorting {
    class InsertionSort {

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
                int location = i;
                //find the correct place in the left of the array.
                for (int j = 0; j < i; j++) {
                    if (a[location] < a[j]) {
                        location = j;
                        break;
                    }
                }
                int element = a[i];
                Console.WriteLine($"{location} <> {i}");
                //shift all elements to the right and make place for this element.
                for (int k = i; k > location; k--) {
                    a[k] = a[k - 1];
                }
                a[location] = element;
            }


        }

    }
}
