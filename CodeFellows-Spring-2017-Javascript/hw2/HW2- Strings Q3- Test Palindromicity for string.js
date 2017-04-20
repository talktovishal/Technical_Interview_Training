function testPalindromicity(str) {
    for (var i = 0, len = str.length; i < len / 2; i++) {
        if (str[i] !== str[len - i - 1])
            return false;
    }
    return true;
}


var tests = {
    "andna": true,
    "ana": true,
    "nn": true,
    "tgh": false,
    "": true,
}

var passed = Boolean(true);
for (var input in tests) {
    var output = testPalindromicity(input);
    console.log('input =' + input + ' actual output = ' + output + ', expected =' + tests[input]);
    passed = passed && (tests[input] === output);
    console.log('');
}

console.log('tests passed? ' + passed);
