'use strict';

class LinkedList {

    constructor() {
        this.head = null;
    }

    Print() {
        var ptr = this.head;
        var represenation = "";
        while (ptr) {
            represenation += ptr.data + " ";
            ptr = ptr.next;
        }
        console.log(represenation)
    }

    InsertNodeAtTail(value) {
        var node = {
            data: value,
            next: null
        };

        if (!this.head) {
            this.head = node;
        } else {
            var ptr = this.head;
            while (ptr.next) {
                ptr = ptr.next;
            }
            ptr.next = node;
        }
    }

    Rearrange() {
        var oddPtr, evenPtr, headOdd, headEven;
        // If linked list is empty
        if (!this.head) {
            console.log('Linked list is empty.');
            return;
        }
        evenPtr = headEven = this.head;
        oddPtr = headOdd = this.head.next;
        var iteration = 0;
        var ptrArray = [evenPtr, oddPtr];
        var lastEvenPtr = evenPtr;
        var isEven = iteration % 2; //0 = true

        while (ptrArray[isEven].next) {
            var nextPtr = ptrArray[isEven].next.next;
            ptrArray[isEven].next = nextPtr;
            ptrArray[isEven] = nextPtr;
            if (isEven === 0 && nextPtr) {
                lastEvenPtr = nextPtr;
            }
            iteration++;
            isEven = iteration % 2;
        }
        lastEvenPtr.next = headOdd;
    }
}


// Create an instance of a LinkedList class
var L1 = new LinkedList();

// Create a linked list with six elements
L1.InsertNodeAtTail(0);
L1.InsertNodeAtTail(1);
L1.InsertNodeAtTail(2);
L1.InsertNodeAtTail(3);
L1.Print();

L1.Rearrange();
L1.Print();