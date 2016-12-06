using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_CSharp.Lecture1.Arrays {
    /*
     Question:
Print a 2-d array (list of lists) in spiral form
Input:
        1    33   3   14
        15   16   7   38
        92   10  11  12
        13   14  15  16
Output: 
1 33 3 14 38 12 16 15 14 13 92 15 16 7 11 10 

Note it doesn't have to be a squre matrix.

    */


    public class PrintSpiral {
        public List<int> spiralOrder(List<List<int>> A)
        {
            int[,] array = new int[A.Count, A[0].Count];
            int row = 0; int col = 0;
            foreach (var list in A) {
                col = 0;
                foreach (var item in list) {
                    array[row, col++] = item;
                }
                row++;
            }
            return SpiralOrderInternal(array, 0, 0, A.Count - 1, A[0].Count - 1);
        }

        public List<int> SpiralOrderInternal(int[,] A, int startRow, int startColumn, int endRow, int endColumn)
        {
            List<int> spiralList = new List<int>();

            if ((startRow == endRow) && (startColumn == endColumn)) {
                spiralList.Add(A[startRow, startColumn]);
                return spiralList;
            }
            for (int i = startColumn; i <= endColumn; i++) {
                spiralList.Add(A[startRow, i]);
            }
            for (int i = startRow + 1; i <= endRow; i++) {
                spiralList.Add(A[i, endColumn]);
            }
            if (startRow != endRow) {
                for (int i = endColumn - 1; i >= startColumn; i--) {
                    spiralList.Add(A[endRow, i]);
                }
            }
            if (startColumn != endColumn) {
                for (int i = endRow - 1; i > startRow; i--) {
                    spiralList.Add(A[i, startColumn]);
                }
            }

            if ((startRow + 1 < endRow) && (startColumn + 1 < endColumn)) {
                spiralList.AddRange(SpiralOrderInternal(A, startRow + 1, startColumn + 1, endRow - 1, endColumn - 1));
            }

            return spiralList;
        }
    }
}
