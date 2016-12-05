package src.ds.algo;
import java.lang.*;



public class Searching implements Comparable<Searching>
{
	int myPrivateId;
	@Override
    public boolean equals(Object obj)
    {
		if(obj == null || !(obj instanceof Searching))
			return false;
        Searching other = (Searching) obj;
        if (this.myPrivateId == other.myPrivateId)
            return true;
        return false;
    }

 
	@Override
    public int compareTo(Searching other)
    {
		if(other == null)
			return 1;
        return (this.myPrivateId - other.myPrivateId);
    }
 


	static boolean searchUnsortedArray(int[] a, int target)
	{
		for (int p = 0; p < a.length; p++) 
		{
			if (target == a[p]) 
				return true;
		}
		return false;
	}
	


	static boolean searchUnsortedArray(Iterable a, Object target)
	{
		for (Object obj : a)
		{
			if (target == obj) 
				return true;
		}
		return false;
	}




	public static void main(String[] args) {
		System.out.println(Searching.searchUnsortedArray(new int[]{3,2,6,1,7,8,9,2}, 7));		
	}



}
