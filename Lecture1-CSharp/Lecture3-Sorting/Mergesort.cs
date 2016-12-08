using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_CSharp.Lecture3_Sorting {
    class Mergesort {


        public static void Run(int[] a)
        {
            RunInternal(a, 0, a.Length - 1);
        }
        public static void RunInternal(int[] a, int left, int right)
        {
            int mid;

            if (right > left) {
                mid = left + (right - left) / 2;
                RunInternal(a, left, mid);
                RunInternal(a, (mid + 1), right);
                DoMerge(a, left, (mid + 1), right);
            }
        }




        public static void DoMerge(int[] a, int left, int mid, int right)
        {
            //need additional space, can be optimized.
            //in-place merge sort -- is possible but hard. 
            int[] temp = new int[a.Length];
            int i, endOfLeftArray, totalElementsToBeMerged, ptr;

            endOfLeftArray = (mid - 1);
            ptr = left;
            totalElementsToBeMerged = (right - left + 1);

            while ((left <= endOfLeftArray) && (mid <= right)) {
                if (a[left] <= a[mid])
                    temp[ptr++] = a[left++];
                else
                    temp[ptr++] = a[mid++];
            }
            //fill in any remaining elements
            while (left <= endOfLeftArray)
                temp[ptr++] = a[left++];
            while (mid <= right)
                temp[ptr++] = a[mid++];

            //copy it back to the main array
            for (i = 0; i < totalElementsToBeMerged; i++) {
                a[right] = temp[right];
                right--;
            }
        }


    }
}
