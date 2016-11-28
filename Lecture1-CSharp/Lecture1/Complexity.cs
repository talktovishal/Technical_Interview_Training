using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_CSharp.Lecture1 {
    class Complexity {
        //        int a = 0, b = 0;    
        //        for (i = 0; i<N; i++) {
        //            a = a + rand();
        //    }
        //        for (j = 0; j<M; j++) {
        //            b = b + rand();
        //}
        // O(N + M) time, O(1) space

        //        int a = 0, b = 0;    
        //    for (i = 0; i<N; i++) {
        //        for (j = 0; j<N; j++) {
        //            a = a + j;
        //        }
        //}
        //    for (k = 0; k<N; k++) {
        //        b = b + k;
        //    } 
        // O(N* N) time, O(1) space

        //fastest time?
        //      A) for(i = 0; i<n; i++)
        //B) for(i = 0; i<n; i += 2)
        //>>>C) for(i = 1; i<n; i *= 2)
        //D) for(i = n; i > -1; i /= 2)


    }
}
