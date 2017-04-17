// JavaScript source code
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

    DeleteNode(value) {
        // If linked list is empty
        if (!this.head) {
            console.log('Linked list is empty.');
            return;
        }

        // if you have to delete the head
        if (this.head.data === value) {
            this.head = this.head.next;
            console.log('deleted head node.');
            return;
        }
        else {
            var current = this.head;
            var next = current.next;
            while (next) {
                if (next.data === value) {
                    current.next = next.next;
                    console.log('deleted node with value =' + value);
                    return;
                }
                else {
                    current = next;
                }
                next = current.next;
            }
        }
        console.log('element not found in list. value =' + value);
    }
}


// Create an instance of a LinkedList class
var L1 = new LinkedList();

// Create a linked list with six elements
L1.InsertNodeAtTail(5);
L1.InsertNodeAtTail(6);
L1.InsertNodeAtTail(7);
L1.InsertNodeAtTail(8);
L1.InsertNodeAtTail(9);
L1.InsertNodeAtTail(10);
L1.Print();

L1.DeleteNode(5);
L1.Print();
L1.DeleteNode(10);
L1.Print();
L1.DeleteNode(77);
L1.Print();
L1.DeleteNode(7);
L1.Print();
