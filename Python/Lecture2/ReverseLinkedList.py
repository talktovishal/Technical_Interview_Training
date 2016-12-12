class Node:
	def __init__(self, value):
		self.data = value
		self.nextPtr = None

class LinkedList:

	# constructor
	def __init__(self):
		self.headPtr = None

	# Function to reverse the linked list
	def reverse(self):
		previous = None
		current = self.headPtr
        #   headPtr --> a --> b --> c --> NULL
        #   NULL    <-- a --> b --> c --> NULL
        #              prev  curr  next 
        #   NULL    <-- a <-- b --> c --> NULL
        #                    prev  curr  next 
        #
		while(current is not None):
			next = current.nextPtr
			current.nextPtr = previous
			previous = current
			current = next
		self.headPtr = previous
		
    #add at the top like a stack
	def add(self, value):
		newNode = Node(value)
		newNode.nextPtr = self.headPtr
		self.headPtr = newNode

	def display(self):
		temp = self.headPtr
		while(temp is not None):
			print temp.data,
			temp = temp.nextPtr


# Driver program to test above functions
list = LinkedList()
list.add(10)
list.add(144)
list.add(115)
list.add(185)
list.add(-5)
list.add(435)

print "Given Linked List"
list.display()

print "\nReversed Linked List"
list.reverse()
list.display()