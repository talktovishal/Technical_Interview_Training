package src.ds.algo;

public class Fibonacci {

	//F(5) => F(4)         + F(3) 
	//     =>{F(3) + F(2)} + F(3).
	public static long fibonacci(int n) 
	{
        if (n <= 1) 
			return n;
        else 
			return fibonacci(n-1) + fibonacci(n-2);
    }


	static long [] dictionary;
	public static long fibonacci_m(int n) 
	{
		if (n == 0) 
		{
		  // special case because fib(0) is 0
		  return dictionary[0];
		}
		else 
		{
		  long f = dictionary[n];
		  if (f == 0) 
		  {
			// number wasn't calculated yet.
			f = fibonacci_m(n-1) + fibonacci_m(n-2);
			dictionary[n] = f;
		  }
		  return f;
		}
	}

}
