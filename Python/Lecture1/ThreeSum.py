

def threeSum(alist):
    for i in range(0, len(alist)):
        for j in range(i+1, len(alist)):
            for k in range(j+1, len(alist)):
                if (alist[i] + alist[j] + alist[k] == 0):
                    print '{} , {} ,{}'.format(alist[i], alist[j], alist[k])


alist = [-2, -1, 0, 1, 2, 3, -4]
threeSum(alist)
print(alist)
