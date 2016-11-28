using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_CSharp.Lecture1.Arrays {
    //Given an array of integers, sort the array into a wave like array and return it, 
    //In other words, arrange the elements into a sequence such that a1 >= a2 <= a3 >= a4 <= a5.....
    /*
        Given [1, 2, 3, 4]
        One possible answer : [2, 1, 4, 3]
        Another possible answer : [4, 1, 3, 2]
        NOTE : If there are multiple answers possible, ret lexicographically smallest -- [2, 1, 4, 3]
    */
    public class WaveArray {
        public List<int> wave(List<int> A)
        {
            List<int> B = new List<int>(A);
            B.Sort();
            for (int i = 0; i < B.Count() -1; i = i+2) {
                int temp = B[i];
                B[i] = B[i + 1];
                B[i + 1] = temp;
            }
            return B;
        }
    }
}
