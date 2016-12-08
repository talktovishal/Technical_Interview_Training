using System;
using System.Collections.Generic;

namespace Lecture1_CSharp
{
    public class BubbleSort
    {
        public static void Run(int[] a)
        {
            int n = a.Length;
            List<int> index = new List<int>();
            for (int i = 0; i < n; i++) {
                index.Add(i);
            }
            Console.WriteLine(string.Join(" | ", index));
            Console.WriteLine(string.Join(" | ", a));
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        Console.WriteLine(string.Join(" | ", a));
                    }
                }
            }
        }//end of Main()

    }//end of class BubbleSort

}
