using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_CSharp.Lecture4 {
    class HeapPseudocode {
        /*
         * 
        

        MAX-HEAPIFY (int[] A, int index)
            left =  LEFT-CHILD(index)
            right =  RIGHT-CHILD(index)
            if left < A.heap-size and A[left] > A[index]
                largest = left
            else 
                largest = index
            if right <=  A.heap-size and A[right] > A[largest]
                largest = right
            if largest != i
                swap A[index] , A[largest]
                MAX-HEAPIFY A, largest



        BUILD-MAX-HEAP (int[] A)
            A.heap-size = A.length
            for i = [A.length / 2]  to 0
                MAX-HEAPIFY (A, i)





        HEAPSORT (int[] A)
            BUILD-MAX-HEAP A
            for i = A:length to 2
                swap A[0] with A[i]
                A.heap-size = A.heap-size - 1
                MAX-HEAPIFY A, 0






        HEAP-EXTRACT-MAX (int[] A)
            if A.heap-size > 0
                max = A[0]
                A[0] = A[A.heap-size - 1]
                A.heap-size = A.heap-size - 1
                MAX-HEAPIFY A, 0
                return max




// increases the value of element x’s key to the new value k,
which is assumed to be at least as large as x’s current key value.




        HEAP-INCREASE-KEY (int[] A, int i, int newValue)
            if newValue > A[i]
                A[i] = newValue
                while i > 0 and A[PARENT(i)] < A[i]
                    swap A[i] , A[PARENT(i)]
                    i = PARENT(i)























        */
    }
}
