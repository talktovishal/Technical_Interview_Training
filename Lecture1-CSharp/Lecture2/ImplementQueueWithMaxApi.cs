using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_CSharp.Lecture2 {
    /*
     basic idea is to do it with two data structures, one is the actual queue containing the 
     elements and the other one is an equivalent of a java Deque -- double ended queue - Deck.
     The reason is say you enqueue 1, 2, 3. Now, you know that 3 is the max. When you deque
     from the queue for two ops() you don't change the max. Also, since 1 was in the queue 
     before 3, there is NO way that 1 will even be the max. Hence, don't bother storing it.
     Consider:
     Q: 3, 1, 3, 2, 0
     D: 3, 3, 2, 0          [the element at the head is the max]

     EQ (1)
     Q: 3, 1, 3, 2, 0, 1
     D: 3, 3, 2, 1

     DQ
     Q: 1, 3, 2, 0, 1
     D: 3, 2, 1


     DQ
     Q: 3, 2, 0, 1
     D: 3, 2, 1


     EQ (4)
     Q: 3, 2, 0, 1, 4
     D: 4

     EQ (4)
     Q: 3, 2, 0, 1, 4, 4
     D: 4, 4


         */
    class ImplementQueueWithMaxApi {

    }
}
