class Node:
    def __init__(self, data):
        self.data = data
        self.next = None
 
 
# Linked List class contains a Node object
class LinkedList:
 
    # Function to initialize head
    def __init__(self):
        self.head = None
        self.size = 0
 
    def incrementSize(self):
        self.size += 1

    def decrementSize(self):
        self.size -= 1

    def add(self, new_data):
 
        new_node = Node(new_data)
 
        if self.head is None:
            self.head = new_node
            self.incrementSize()
            return
 
        last = self.head
        while (last.next):
            last = last.next
 
        last.next =  new_node
        self.incrementSize()
 
 
    def printList(self):
        temp = self.head
        while (temp):
            print temp.data,
            temp = temp.next
 
 
 
if __name__=='__main__':
 
    llist = LinkedList()
    llist.add(1)
    llist.add(2)
    llist.add(3)
    llist.add(4)
    llist.add(5)
    llist.add(6)
    llist.add(7)
    llist.add(8)
    print 'Created linked list is:',
    llist.printList()
 
