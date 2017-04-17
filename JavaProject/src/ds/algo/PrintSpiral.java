package src.ds.algo;
import java.util.*;

public class PrintSpiral
{
	public enum Direction {
		Left,
		Right,
		Up,
		Down,
	}

	public ArrayList<Integer> spiralOrder(final List<ArrayList<Integer>> A) {
		 ArrayList<Integer> result = new ArrayList<Integer>();
		 // Populate result;
		 int m, n;
		 m = A.size();
		 n = A.get(0).size();
		 if (m == 0)
		    return result;
		 
		 int len;
		 Direction dir = Direction.Right;
		 //the layer keep tracks of the spiral. we try to take one full round.
		 //after one full round, then  
		 int row, col, layer;
		 row = col = layer = 0;
		 
		 result.add(A.get(0).get(0));
		 
        
        for (int step = 1; step < m * n; step++) {
            switch(dir) {
                // Go right
                case Right:
                    if (col == n - layer - 1) {
                        dir = Direction.Down;
                        row++;
                    } else {
                        col++;
                    }
                    break;
                    
                // Go down
                case Down:
                    if (row == m - layer - 1) {
                        dir = Direction.Left;
                        col--;
                    } else {
                        row++;
                    }
                    break;
                    
                // Go left
                case Left:
                    if (col == layer) {
                        dir = Direction.Up;
                        row--;
                    } else {
                        col--;
                    }
                    break;
                
                // Go up
                case Up:
                    if (row == layer + 1) {
                        dir = Direction.Right;
                        col++;
                        layer++;
                    } else {
                        row--;
                    }
                    break;
            }
            
            //System.out.println(row + " " + col);
            result.add(A.get(row).get(col));
        }
		return result;
	}


}
