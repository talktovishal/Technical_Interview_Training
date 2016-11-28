package src.ds.algo;

//simple stack that only stores integers
public class Stack {
      private int top;
      private int[] storage;
 
      Stack(int capacity) {
            if (capacity <= 0)
                  throw new IllegalArgumentException("Be positive!");
            storage = new int[capacity];
            top = -1;
      }

      boolean isEmpty() {
            return (top == -1);
      }

 
      void push(int value) {
            if (top == storage.length)
                  throw new StackException("No more space in stack!");
            top++;
            storage[top] = value;
      }

 
      int peek() {
            if (top == -1)
                  throw new StackException("Nothing in stack to get!");
            return storage[top];
      }
 
      int pop() {
			// decrement top and return the data
			int value = peek();
            top--;
			//would you do something more if we were storing objects? why?
			return value;
      }
 
 
      public class StackException extends RuntimeException {
            public StackException(String message) {
                  super(message);
            }
      }
}