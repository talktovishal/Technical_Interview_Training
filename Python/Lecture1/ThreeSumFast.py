import bisect

def threeSumFast(alist):
    alist.sort()
    for i in range(0, len(alist)):
        for j in range(i+1, len(alist)):
            k = bisect.bisect_right(alist , -(alist[i] + alist[j]));
            if (k > j) and  ( k < len(alist) ):
                print '{} , {} ,{}'.format(alist[i], alist[j], alist[k])


alist = [-2, -1, 0, 1, 2, 3, -4]
threeSumFast(alist)
print(alist)
