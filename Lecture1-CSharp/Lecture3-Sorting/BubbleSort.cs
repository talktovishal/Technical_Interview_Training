using System;

namespace Lecture1_CSharp
{
    public class BubbleSort
    {
        public static void Run(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }

            foreach (int i in a)
                Console.WriteLine("{0},", i);

        }//end of Main()

    }//end of class BubbleSort

}
