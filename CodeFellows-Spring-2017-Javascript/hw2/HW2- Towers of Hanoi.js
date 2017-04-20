function Stack() {
    this.container = [];
    this.name = '';
}

Stack.prototype.push = function (src, data) {
    if (this.container.length > 0)//constraint check
    {
        if (this.peek() < data) {
            throw new Error('constrain check violated. disc #' + data + ' cannot be added on top of disc #' + this.peek());
        }
    }
    if (src !== '')
        console.log(' Moving disc#' + data + ' from ' + src + ' to ' + this.name);
    this.container.push(data);
}

Stack.prototype.peek = function () {
    return (this.container[this.container.length - 1]);
}

Stack.prototype.pop = function () {
    var data = this.container[this.container.length - 1];
    this.container.pop();
    return data;
}

function SolveTowersOfHanoii(P1_source, P2_temp, P3_dest, N_NumberOfDiscs) {
    if (N_NumberOfDiscs > 1)
        SolveTowersOfHanoii(P1_source, P3_dest, P2_temp, N_NumberOfDiscs - 1);

    P3_dest.push(P1_source.name, P1_source.pop());
    //console.log(' Moving disc ' + N_NumberOfDiscs + ' from ' + P1_source + ' to ' + P3_dest);

    if (N_NumberOfDiscs > 1)
        SolveTowersOfHanoii(P2_temp, P1_source, P3_dest, N_NumberOfDiscs - 1);
}

Peg1 = new Stack(); Peg1.name = 'Peg1';
Peg1.push('', 1);
Peg2 = new Stack(); Peg2.name = 'Peg2';
Peg3 = new Stack(); Peg3.name = 'Peg3';
SolveTowersOfHanoii(Peg1, Peg2, Peg3, 1);

console.log('');


Peg1 = new Stack(); Peg1.name = 'Peg1';
Peg1.push('', 2);
Peg1.push('', 1);
Peg2 = new Stack(); Peg2.name = 'Peg2';
Peg3 = new Stack(); Peg3.name = 'Peg3';
SolveTowersOfHanoii(Peg1, Peg2, Peg3, 2);

console.log('');


Peg1 = new Stack(); Peg1.name = 'Peg1';
Peg1.push('', 3);
Peg1.push('', 2);
Peg1.push('', 1);
Peg2 = new Stack(); Peg2.name = 'Peg2';
Peg3 = new Stack(); Peg3.name = 'Peg3';
SolveTowersOfHanoii(Peg1, Peg2, Peg3, 3);

/*
initial version as shown in common solutions
SolveTowersOfHanoii('Peg1', 'Peg2', 'Peg3', 1);
console.log('');
SolveTowersOfHanoii('Peg1', 'Peg2', 'Peg3', 2);
console.log('');
SolveTowersOfHanoii('Peg1', 'Peg2', 'Peg3', 3);
console.log('');
SolveTowersOfHanoii('Peg1', 'Peg2', 'Peg3', 5);
*/