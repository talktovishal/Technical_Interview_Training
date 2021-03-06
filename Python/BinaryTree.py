import Queue
# Node has a value and two children
class Node:
    def __init__(self, val, counter):
        self.name = chr(ord('a') + counter)
        self.leftChild = None
        self.rightChild = None
        self.AggregatedSum = 0
        self.InTheValidPath = False
        self.value = val

# tree has a root node. that's the only 
# member it requires.
class Tree:
    
    #constructor, empty root.
    def __init__(self):
        self.root = None
        self.size = 0;

    def getRoot(self):
        return self.root


    def add(self, val):
        #if it's empty
        if(self.root == None):
            self.root = Node(val, self.size)
        else:
            self.addInternal(val, self.root)
        self.size += 1        

    #recursive add
    def addInternal(self, val, node):
        if(val < node.value):
            if(node.leftChild != None):
                self.addInternal(val, node.leftChild)
            else:
                node.leftChild = Node(val, self.size)
        else:
            if(node.rightChild != None):
                self.addInternal(val, node.rightChild)
            else:
                node.rightChild = Node(val, self.size)



    #binary search
    def find(self, val):
        if(self.root != None):
            return self.findInternal(val, self.root)
        else:
            return None


    def findInternal(self, val, node):
        if(val == node.value):
            return node
        elif(val < node.value and node.leftChild != None):
            return self.findInternal(val, node.leftChild)
        elif(val > node.value and node.rightChild != None):
            return self.findInternal(val, node.rightChild)
        else:#not present
            return None

        
    
    #In a breadth first traversal all of the nodes on a given level 
    #are visited and then all of the nodes on the next level are visited.
    #QUEUE
    def traverse_bfs(self):
        if(self.root != None):
            queue = Queue.Queue()
            queue.put(self.getRoot())
            while queue.qsize() != 0:
                node = queue.get()
                if node.leftChild:
                    queue.put(node.leftChild)
                if node.rightChild:
                    queue.put(node.rightChild)
                print node.value
                print node.name



    #In a depth first traversal all the nodes on a path are visited before 
    #any others are visited
    #STACK
    #here a recurrsive variant.
    def traverse_dfs_preorder(self):
        if(self.root != None):
            self.traverse_dfs_preorder_internal(self.root)


    def traverse_dfs_preorder_internal(self, node):
        print(node.value)
        if node.leftChild:
            self.traverse_dfs_preorder_internal(node.leftChild)
        if node.rightChild:
            self.traverse_dfs_preorder_internal(node.rightChild)


    def printSinglePath(self):
        node = self.root
        while(node != None and node.InTheValidPath):
            print node.name
            print node.value
            if(node.leftChild and node.leftChild.InTheValidPath):
                node = node.leftChild
            elif(node.rightChild and node.rightChild.InTheValidPath):
                node = node.rightChild
            else:
                node = None


    def doesSumExist(self, sum):
        if(self.root != None):
            doesExist = self.doesSumExist_internal(self.root, 0, sum)
            if doesExist:
                printSinglePath()
            else:
                print('does not exist')


    def doesSumExist_internal(self, node, currentSum, sumNeeded):
        node.AggregatedSum = currentSum + node.value
        if(node.AggregatedSum == sumNeeded):
            node.InTheValidPath = True
            return True
        if node.leftChild and node.InTheValidPath != True:
            node.InTheValidPath = self.doesSumExist_internal(node.leftChild, node.AggregatedSum, sumNeeded)
        if node.rightChild and node.InTheValidPath != True:
            node.InTheValidPath = self.doesSumExist_internal(node.rightChild, node.AggregatedSum, sumNeeded)
        return node.InTheValidPath



#    excercise
#    def traverse_dfs_postorder(self):

#    delete
#    def delete(node):


tree = Tree()
tree.add(56)
tree.add(26)
tree.add(200)
tree.add(18)
tree.add(28)
tree.add(190)
tree.add(213)
tree.add(12)
tree.add(24)
tree.add(27)
print ('tree.traverse_bfs()')
tree.traverse_bfs()
print ('tree.traverse_dfs_preorder()')
tree.traverse_dfs_preorder()
print tree.find(10)
print (tree.find(213)).value
tree.doesSumExist(124)
##tree.doesSumExist(122)