package src.ds.algo;
import java.util.*;

public class CountTriplets
{

	static int countTriplets(int array[], int sum)
	{
		Arrays.sort(array);
		int n = array.length;
		// Initialize result
		int ans = 0;
 
		// Every iteration of loop counts triplet with
		// first element as array[i].
		for (int i = 0; i < n - 2; i++)
		{
			// Initialize other two elements as corner elements
			// of subarray array[j+1..k]
			int left = i + 1, right = n - 1;
 
			while (left < right)
			{
				// If sum of current triplet is more or equal,
				// move inwards (right pointer) to look for smaller values
				if (array[i] + array[left] + array[right] >= sum)
					right--;
 
				// Else move left pointer
				else
				{
					// This is important. For current i and j, there
					// can be total k-j third elements.
					ans += (right - left);
					left++;
				}
			}
		}
		return ans;
	}


}
