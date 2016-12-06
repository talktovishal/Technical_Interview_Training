using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_CSharp.Lecture1.Arrays {
    class SmallestPositiveNumberModifyArray {
        /* Utility function that puts all non-positive (0 and negative) numbers on left 
          side of arr[] and return count of such numbers */
        int segregate(int[] arr)
        {
            int j = 0, i;
            for (i = 0; i < arr.Length; i++) {
                if (arr[i] <= 0) {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j++;  // increment count of non-positive integers
                }
            }
            return j;
        }

        /* Find the smallest positive missing number in an array that contains
          all positive integers */
        int findMissingPositive(int[] arr, int startAt)
        {
            int i;
            int modifiedSize = arr.Length - startAt;
            // Mark arr[i] as visited by making arr[arr[i] - 1] negative. Note that 
            // 1 is subtracted because index start from 0 and positive numbers start 
            // from 1
            //Console.WriteLine($"startAt={startAt}, arr.Length={arr.Length}");
            //Console.WriteLine(string.Join(",", arr));
            for (i = startAt; i < arr.Length; i++) 
            {
                int indexToModify = startAt + Math.Abs(arr[i]) - 1;
                //Console.WriteLine($"i={i},   arr[i] = {arr[i]} => indexToModify = [{indexToModify}]");
                if (indexToModify < arr.Length && arr[indexToModify] > 0)
                    arr[indexToModify] = -1 * arr[indexToModify];//toggle the sign to specify it's present.
                //Console.WriteLine(string.Join(",", arr));
            }
            //Console.WriteLine(string.Join(",", arr));
            // Return the first index value at which is positive
            for (i = startAt; i < modifiedSize; i++) {
                if (arr[i] > 0)
                    return (i - startAt +1);  // 1 is added because indexes start from 0
            }
            
            //if not found.
            return modifiedSize + 1;
        }

        /* Find the smallest positive missing number in an array that contains
          both positive and negative integers */
        public int firstMissingPositive(List<int> A)
        {
            int[] arr = A.ToArray<int>();
            // First separate positive and negative numbers
            int shift = segregate(arr);

            // Shift the array and call findMissingPositive for
            // positive part
            return findMissingPositive(arr, shift);
        }
    }
}
