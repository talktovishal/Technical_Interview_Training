package src.ds.algo;
import java.lang.*;
import java.util.*;

//Rotated Sorted Array Search
/*
A sorted array is rotated at some unknown pivot.
(i.e., 30 31 32 34 35 36 37  might become 34 35 36 37 30 31 32 ).
Find 30 => 4.
Assume no duplicates.
*/
public class RotatedArraySearch
{
	// DO NOT MODIFY THE LIST
	public int search(final List<Integer> a, int b) {
        int pivot = 0;
		int find = a.get(a.size() -1);
        int low = 0, high = a.size() -1;
        int found = -1;
        int mid = -1;
        while(low <= high) {
            mid = low + (high - low) / 2;
            if (a.get(mid) <= find){
				high = mid - 1;
				pivot = mid;
			}
            else if (a.get(mid) > find)
                low = mid + 1;
        }

		int startIndex = BinarySearch(a, b, 0, pivot -1);
		if(startIndex != -1)
			return startIndex;
        return BinarySearch(a, b, pivot, a.size() -1);
	}
	
    public static int BinarySearch(List<Integer> list, int find)
	{
		return BinarySearch(list, find, 0, Integer.MIN_VALUE);
	}
    public static int BinarySearch(List<Integer> list, int find, int start, int end)
    {
        if (end == Integer.MIN_VALUE)
            end = list.size() - 1;

        int low = start, high = end;
        int found = -1;
        int mid = -1;
        while(low <= high) {
            mid = low + (high - low) / 2;
            if (list.get(mid) == find)
                return mid;
            else if (list.get(mid) > find)
                high = mid - 1;
            else
                low = mid + 1;
        }
        return found;
    }


		
}
