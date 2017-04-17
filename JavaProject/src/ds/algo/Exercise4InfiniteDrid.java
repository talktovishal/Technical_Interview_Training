package src.ds.algo;
import java.util.*;

public class Exercise4InfiniteDrid
{
    // X and Y co-ordinates of the points in order.
    // Each point is represented by (X.get(i), Y.get(i))
    public int coverPoints(ArrayList<Integer> X, ArrayList<Integer> Y) {
		//points are p1, p2, p3, p4... 
		//given any two points, if the x or y axis is same, then solution is trivial.
		//if not, 
		//One way to reach form a point (x1,y1) to (x2, y2) is to move abs(x2-x1) steps in horizontal direction 
		//and abs(y2-y1) steps in vertical direction, but this is not the shortest path to reach (x2,y2). The best way 
		//would be to cover the maximum possible distance in diagonal direction and remaining in horizontal or vertical 
		//direction. If we look closely this just reduces to maximum of abs(x2-x1) and abs(y2-y1).
		int steps =0;
		for(int i =0; i<X.size()-1; i++)
		{
            steps += (Math.abs(X.get(i) - X.get(i+1)) < Math.abs(Y.get(i) - Y.get(i+1))) ?
                            Math.abs(Y.get(i) - Y.get(i+1)) : Math.abs(X.get(i) - X.get(i+1));
		    
		}
		return steps;
    }

}
