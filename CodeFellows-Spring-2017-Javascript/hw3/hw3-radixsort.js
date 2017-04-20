
var getNthDigit = function (num, nth) {
    num = Math.abs(num);
    // get last nth digit of a number
    var digit = 0;
    while (nth--) {
        digit = num % 10
        num = Math.floor((num - digit) / 10)
    }

    return digit;
}

// radixSort
function radixSort(list) {
    //there can be both positive an negative numbers.
    //for the negative numbers, we treate the negative sign as a special digit.
    var positiveArray = []
    var doesNegativeNumberExist = false;
    for (var j = 0; j < list.length; j++) {
        if (list[j] < 0)
            doesNegativeNumberExist = true;
        positiveArray[j] = Math.abs(list[j])
    }

    var maximumValue = Math.max.apply(null, positiveArray);
    console.log(maximumValue);
    // get the length of digits of the max value in this array
    var maxNumberOfDigits = Math.floor(Math.log10(Math.abs(maximumValue))) + 1;

    /*ideally, i would have found the max of abs negetive numbers and max of positive numbers
    and then added one only as needed. So it may be doing one extra when not needed and that's ok
    eg: -1,4,5,631.*/
    if (doesNegativeNumberExist)
        maxNumberOfDigits += 1;


    digitBuckets = [];
    index = 0;

    console.log(maxNumberOfDigits);

    for (var digitIndex = 0; digitIndex < maxNumberOfDigits; digitIndex++) {
        // rebuild the digit buckets according to this digit
        digitBuckets = []

        if (doesNegativeNumberExist && (digitIndex === maxNumberOfDigits - 1)) {

            for (j = 0; j < list.length; j++) {
                digit = list[j] < 0 ? 0 : 1;
                digitBuckets[digit] = digitBuckets[digit] || []; //if null then init to empty array
                digitBuckets[digit].push(list[j]);
            }

            //the negative numbers are going to be arranged in the opposite order. hence, i need to do something different.
            // rebuild the list according to this digit
            index = 0
            //only have two buckets in the last iteration.
            if (digitBuckets[0] && digitBuckets[0].length > 0) {
                for (j = digitBuckets[0].length - 1; j >= 0; j--) {
                    list[index++] = digitBuckets[0][j];
                }
            }

            if (digitBuckets[1] && digitBuckets[1].length > 0) {
                for (j = 0; j < digitBuckets[1].length; j++) {
                    list[index++] = digitBuckets[1][j];
                }
            }

        }
        else {
            for (j = 0; j < list.length; j++) {
                //0 is the 1st digit of the number
                var digit = getNthDigit(list[j], digitIndex + 1);
                digitBuckets[digit] = digitBuckets[digit] || []; //if null then init to empty array
                digitBuckets[digit].push(list[j]);
            }

            // rebuild the list according to this digit
            index = 0
            for (digitBucketIndex = 0; digitBucketIndex < digitBuckets.length; digitBucketIndex++) {
                if (digitBuckets[digitBucketIndex] && digitBuckets[digitBucketIndex].length > 0) {
                    for (j = 0; j < digitBuckets[digitBucketIndex].length; j++) {
                        list[index++] = digitBuckets[digitBucketIndex][j];
                    }
                }
            }
        }
        console.log('digitIndex = ' + digitIndex + ',list = ' + list)
    }
    return list
}

var arr = [801, 2, 5, 1, 56, 23, 41, 87, 12]
//var arr = [2,5,1,56,23,45,87,12,34,78,34,14,71,91,19,652,211,801]
//var arr = [-2,-5,-1,-56,-23,-801]
//var arr = [2,5,1,56,23,45,78,34,14,71,91,-2,-5,-1,-56,-23,-801,19,652,211,-900,801]
console.log(arr)
radixSort(arr)
console.log(arr)