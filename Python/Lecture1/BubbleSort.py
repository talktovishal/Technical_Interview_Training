def bubbleSort(alist):
    for i in range(0, len(alist)):
        for j in range(0, len(alist) - i - 1):
            if (alist[j] > alist[j + 1]):
                temp = alist[j];
                alist[j] = alist[j + 1];
                alist[j + 1] = temp;


alist = [1, 3, 5, 6, 2, 4, 8, 2, 4, 6, 8, 3]
bubbleSort(alist)
print(alist)
