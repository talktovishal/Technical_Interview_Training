'use strict';

function Node(value, left, right, parent) {
    this._value = value;
    this._left = left;
    this._right = right;
    this._parent = parent;
}

Node.prototype.print = function () {
    console.log('[node]' + this._value);
}


function BinarySearchTree() {
    this._root = null;
}

BinarySearchTree.prototype.insert = function (value, current) {
    if (this._root === null) {
        this._root = new Node(value, null, null, null);
        //console.log('add at root.')
        return;
    }

    var insertKey;
    current = current || this._root;
    if (current._value > value) {
        insertKey = '_left';
    } else {
        insertKey = '_right';
    }
    //console.log('insertKey = ' + insertKey);

    if (!current[insertKey]) {
        //console.log('added at = ' + insertKey);
        //insert if no child is present.
        current[insertKey] = new Node(value, null, null, current);
    } else {
        //recurrsive call.
        this.insert(value, current[insertKey]);
    }
}


BinarySearchTree.prototype.find = function (value) {
    return this._find(value, this._root);
}

BinarySearchTree.prototype._find = function (value, current) {
    if (!current) {
        return null;
    }
    if (current._value === value) {
        return current;
    }
    if (current._value > value) {
        return this._find(value, current._left);
    }
    if (current._value < value) {
        return this._find(value, current._right);
    }
}

//for the parent node, replace the oldChild with the new child
BinarySearchTree.prototype._replaceChild = function (parent, oldChild, newChild) {
    if (!parent) {
        //replacing the root.
        this._root = newChild;
        if (this._root !== null) {
            this._root._parent = null;
        }
    } else {
        if (parent._left === oldChild) {
            parent._left = newChild;
        } else {
            parent._right = newChild;
        }
        if (newChild) {
            newChild._parent = parent;
        }
    }
}

BinarySearchTree.prototype.print = function () {
    console.log('');
    var indent = 1;
    this._walk('R', this._root, indent);
    console.log('');
}

BinarySearchTree.prototype._walk = function (type, node, indent) {
    console.log('--' + Array(indent).join('--') + '[' + type + ']', node._value);
    if (node._left) {
        this._walk('L', node._left, indent + 1);
    }
    if (node._right) {
        this._walk('R', node._right, indent + 1);
    }
}

BinarySearchTree.prototype.removeValue = function (data) {
    var nodeToBeRemoved = this.find(data);
    nodeToBeRemoved.print();
    if (nodeToBeRemoved) {
        this.remove(nodeToBeRemoved);
    }
}

BinarySearchTree.prototype._findSuccesor = function (node, current) {
    current = current || { _value: Infinity };//to handle base case
    if (!node) {
        return current;
    }

    if (current._value > node._value) {
        current = node;
    }
    //trying to find the left-most aka minimum element. when called on the 
    //right child, this function will return the successor
    return this._findSuccesor(node._left, current);
}

BinarySearchTree.prototype.remove = function (node) {
    if (!node) {
        return false;
    }
    if (node._left && node._right) {
        //it has two children. First is find the successor.
        var successor = this._findSuccesor(node._right);
        var temp = node._value;
        node._value = successor._value;
        //the idea is i swap the successor to the current node's value 
        //and then remove the succesor. this looks like a recursive call
        //but note it will at most be called once.
        successor._value = temp;
        return this.remove(successor);
    } else {
        if (node._left) {
            this._replaceChild(node._parent, node, node._left);
        } else if (node._right) {
            this._replaceChild(node._parent, node, node._right);
        } else {
            this._replaceChild(node._parent, node, null);
        }
        return true;
    }
}




var bst = new BinarySearchTree();
bst.insert(2000);
bst.insert(1989);
bst.insert(1991);
bst.insert(2001);
bst.insert(1966);
bst.insert(2050);
bst.insert(2000);
bst.insert(2015);
bst.insert(2030);
bst.insert(2075);
bst.insert(2020);
bst.insert(2035);
bst.print();

//bst.removeValue(1991);
bst.removeValue(2001);
bst.print();
