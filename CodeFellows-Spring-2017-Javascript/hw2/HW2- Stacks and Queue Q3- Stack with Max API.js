function Stack() {
    this.container = [];
    this.name = '';
}

Stack.prototype.push = function (data) {
    this.container.push(data);
}

Stack.prototype.isEmpty = function () {
    return (this.container.length === 0);
}

Stack.prototype.peek = function () {
    return (this.container[this.container.length - 1]);
}

Stack.prototype.pop = function () {
    var data = this.container[this.container.length - 1];
    this.container.pop();
    return data;
}

/*
Idea: We have two stacks, a regular one for storing the values
and the secondary one for keeping track of what's the maximum value
at that point. The way we push pop data in that stack is
we add to it iff we see a value greater than or equal to it's 
current value.
*/
function StackWithMaxApi() {
    this.regularStack = new Stack();
    this.maxStack = new Stack();
}

StackWithMaxApi.prototype.push = function (data) {
    if (this.regularStack.isEmpty() === true) {
        this.regularStack.push(data);
        this.maxStack.push(data);
    }
    else {
        this.regularStack.push(data);
        /* push only when the incoming element of main stack is >= to top stack */
        if (data >= this.maxStack.peek())
            this.maxStack.push(data);
    }
}

StackWithMaxApi.prototype.pop = function () {
    var data = this.regularStack.pop();
    if (this.maxStack.peek() === data)
        this.maxStack.pop();

    return data;
}

StackWithMaxApi.prototype.getMax = function () {
    return this.maxStack.peek();
}

var s = new StackWithMaxApi();
s.push(10);
s.push(20);
s.push(30);
s.push(10);
s.push(20);
console.log(s.getMax());
s.push(5);
console.log(s.getMax());
s.push(50);
console.log(s.getMax());
s.pop();
s.pop();
s.pop();
console.log(s.getMax());
s.pop();
s.pop();
s.pop();
console.log(s.getMax());
s.pop();
console.log(s.getMax());