package ds.algo;


public class linkedlist  {

 	private static int size;
	private Node head;
 
	private class Node {
		Node next;
		Object data;
 
		// Node constructor
		public Node(Object dataValue) {
			next = null;
			data = dataValue;
		}
 
		public Object getData() {
			return data;
		}
 
		public Node getNext() {
			return next;
		}
 
		public void setNext(Node nextValue) {
			next = nextValue;
		}
	}

	// Default constructor
	public linkedlist() {
 
	}


	public static linkedlist s_linkedlist;
 
//	public static void main(String[] args) {
// 		s_linkedlist = new linkedlist();
//		// add elements
//		s_linkedlist.add("1");
//		s_linkedlist.add("2");
//		s_linkedlist.add("3");
//		s_linkedlist.add("4");
//		s_linkedlist.add("5");
//		s_linkedlist.add("6");
//		s_linkedlist.add("7");
//		s_linkedlist.add("8");
//		System.out.println("1--------------------------------------");
//		System.out.println("Print: s_linkedlist: \t\t" + s_linkedlist);
//		System.out.println(".get(3): \t\t\t\t" + s_linkedlist.get(3) + " (get element at index:3 - list starts from 0)");
//		System.out.println(".removeAt(2): \t\t\t" + s_linkedlist.removeAt(7) + " (element removed)");
//		System.out.println("Print: s_linkedlist: \t\t" + s_linkedlist);
//		System.out.println(".get(3): \t\t\t\t" + s_linkedlist.get(3) + " (get element at index:3 - list starts from 0)");
//		System.out.println(".removeAt(6): \t\t\t" + s_linkedlist.removeAt(6) + " (element removed)");
//		System.out.println("Print: s_linkedlist: \t\t" + s_linkedlist);
//		System.out.println("");
//	}
 
 
	// appends the specified element to the end of this list.
	public void add(Object data) {
		Node temp = new Node(data);
		if (head == null) {
			head = temp;
 			incrementSize();
			return;
		}

		Node current = head;
 
		// go to the end and add to the list
		while (current.getNext() != null) {
			current = current.getNext();
		}
		// the last node's "next" reference set to our new node
		current.setNext(temp);

 		incrementSize();
	}
 

	private static int getSize() {
		return size;
	}
 
	private static void incrementSize() {
		size++;
	}
 
	private void decrementSize() {
		size--;
	}
 

	public Object get(int index)
	// returns the element at the specified position in this list.
	{
		// index must be 1 or higher
		if (index < 0)
			return null;
		Node current = head;
		int counter = 0;
		while (current != null) {
			if(index == counter++)
				return current.getData();
			current = current.getNext();
		}
		return current;
 	}

 
	public boolean removeAt(int index) {
 		// if the index is out of range, exit
		if (index < 0 || index > (size() -1))
			return false;
		
		if(index == 0)
		{
			head = head.getNext();
			decrementSize();
			return true;
		}

		//node -> current -> next >> prev -> next
		Node current = head;
		int counter = 1;
		while (current != null) {
			if(counter ==  index) {
				if(current.getNext() != null) {
					current.setNext(current.getNext().getNext());
				}
				else {
					current.setNext(null);
				}
				decrementSize();
				return true;
			}
			current = current.getNext();
			counter ++;
		}

		return false;
	}
 
	// returns the number of elements in this list.
	public int size() {
		return getSize();
	}
 
	public String toString() {
		String output = "Size = " + size + " ";
		
		if (head != null) {
			Node current = head;
			while (current != null) {
				output += "[" + current.getData().toString() + "]";
				current = current.getNext();
			}
 		}
		return output;
	}
 

	
}
