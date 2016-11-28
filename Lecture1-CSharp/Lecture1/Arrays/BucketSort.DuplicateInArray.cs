using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_CSharp.Lecture1.Arrays {

    //need bucket sort
    //https://www.interviewbit.com/problems/find-duplicate-in-array/
    class DuplicateInArray {
        public int repeatedNumber(List<int> A)
        {
            int sum = 0;
            int N = A.Count;
            for (int i = 0; i < N; i++) {
                sum += A[i];
            }
            return sum - (N * (N + 1)) / 2;
        }
    }
}
