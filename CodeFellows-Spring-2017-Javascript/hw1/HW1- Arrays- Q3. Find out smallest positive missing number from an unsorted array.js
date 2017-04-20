function findSmallestMissingPositiveNumber(strArray) {
    console.log('original array = ' + strArray);
    var array = JSON.parse("[" + strArray + "]");
    //first separate the positive from the negative numbers.
    var left = 0; right = array.length - 1;
    var leftBoundary = 0; rightBoundary = array.length - 1;

    while (left < right) {
        while (array[left] < 0 & left < rightBoundary)
            left++;
        while (array[right] >= 0 & right > leftBoundary)
            right--;

        //swap if needed
        if (left < right) {
            var temp = array[left];
            array[left] = array[right];
            array[right] = temp;

            left++;
            right--;
        }
    }

    //what's the boundary, if any?
    left = -1; //all positive values
    while ((left < (rightBoundary - 1)) && array[left + 1] < 0)
        left++;
    leftBoundary = left;
    console.log('segregated array =' + array + ', leftBoundary =' + leftBoundary);

    //now find the smallest missing +ve number. note, use the index 0 to tag 1, index 1 to tag 2, and so on...
    for (var index = leftBoundary + 1; index < rightBoundary; index++) {
        var valueToUpdate = Math.abs(array[index]);//doing this since someone may have toggled the sign before.
        if (valueToUpdate <= array.length) {
            var indexToUpdate = valueToUpdate - 1;
            //change the sign
            array[indexToUpdate] = (-1) * array[indexToUpdate];
        }
    }

    console.log('updated signs array =' + array);

    //now find the first number where the sign is NOT changed. That mean's it's absent
    left = 0;
    while (left < rightBoundary) {
        if (left <= leftBoundary && array[left] < 0)//should be +ve if found
            return (left + 1);
        if (left > leftBoundary && array[left] > 0)
            return (left + 1);
        left++;
    }

    return (array.length + 1);
}


var tests = {
    "5, 7, 4, 18, -21, -1, 67": 1,
    "-1, 4, 6, 8, -90, 1, 0, -21": 2,
    "1, 2, 3, 4, 5, 6, 7": 8
}

var passed = Boolean(true);
for (var input in tests) {
    var output = findSmallestMissingPositiveNumber(input);
    console.log('input =' + input + ' actual output = ' + output + ', expected =' + tests[input]);
    passed = passed && (tests[input] === output);
    console.log('');
}
console.log('tests passed? ' + passed);
