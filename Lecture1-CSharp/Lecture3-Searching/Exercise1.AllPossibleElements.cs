using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_CSharp.Lecture3_Searching {

    //Given a sorted array of integers, find the total number of occurrences of an integer.
    class AllPossibleElements {
        public static int TotalCount(List<int> list, int find)
        {
            int startIndex = -1, endIndex = -1;
            startIndex = endIndex = BinarySearch(list, find);
            if (startIndex == -1)
                return 0;
            //atleast one count was found. So find total by finding the leftmost & the 
            //rightmost counts
            int lastStartIndex = startIndex, lastEndIndex = endIndex;
            while(startIndex != -1) {
                lastStartIndex = startIndex;
                startIndex = BinarySearch(list, find, 0, startIndex - 1);
            }
            while (endIndex != -1) {
                lastEndIndex = endIndex;
                endIndex = BinarySearch(list, find, endIndex + 1);
            }
            return (lastEndIndex - lastStartIndex + 1);
        }

        //returns the index
        public static int BinarySearch(List<int> list, int find, int start = 0, int end = Int32.MinValue)
        {
            if (end == Int32.MinValue)
                end = list.Count -1;

            int low = start, high = end;
            int found = -1;
            int mid = -1;
            while(low <= high) {
                mid = low + (high - low) / 2;
                if (list[mid] == find)
                    return mid;
                else if (list[mid] > find)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return found;
        }
    }
}
