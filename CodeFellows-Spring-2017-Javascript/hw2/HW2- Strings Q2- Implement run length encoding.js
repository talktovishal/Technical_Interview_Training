function RLE(str) {
    var rle = [];
    var previousChar = str[0];
    var counter = 0;
    for (var i = 0, len = str.length; i < len; i++) {
        if (str[i] === previousChar)
            counter++;
        else {
            rle.push(counter);
            rle.push(previousChar);
            previousChar = str[i];
            counter = 1;
        }
    }
    rle.push(counter);
    rle.push(previousChar);
    return rle.join('');
}


var tests = {
    "aaaabcccaa": "4a1b3c2a",
    "eeeffffee": "3e4f2e",
}

var passed = Boolean(true);
for (var input in tests) {
    var output = RLE(input);
    console.log('input =' + input + ' actual output = ' + output + ', expected =' + tests[input]);
    passed = passed && (tests[input] === output);
    console.log('');
}

console.log('tests passed? ' + passed);
