def fibR(n):
    if n == 1 or n == 2:
        return 1
    return fibR(n - 1) + fibR(n - 2)

#F(5) => F(4)         + F(3) 
#     =>{F(3) + F(2)} + F(3).


def memoize(fn, arg):
 memo = {}
 if arg not in memo:
  memo[arg] = fn(arg)
  return memo[arg]

fibm = memoize(fib,5)
