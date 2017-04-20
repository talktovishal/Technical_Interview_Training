var map = {
    '1': '*',
    '2': 'abc',
    '3': 'def',
    '4': 'ghi',
    '5': 'jkl',
    '6': 'mno',
    '7': 'pqrs',
    '8': 'tuv',
    '9': 'wxyz',
}


function printMnemonics(strPhoneNumber) {
    output = [];
    printMnemonicsInternal('', strPhoneNumber, output);
    return output;
}


function printMnemonicsInternal(prefix, remainingPhoneNumber, output) {
    if (remainingPhoneNumber.length === 1) {
        var possibleChars = map[remainingPhoneNumber[0]];
        for (var i = 0, len = possibleChars.length; i < len; i++)
            //console.log(prefix + possibleChars[i]);
            output.push(prefix + possibleChars[i]);
        //console.log(output);
    } else {
        possibleChars = map[remainingPhoneNumber[0]];
        for (i = 0, len = possibleChars.length; i < len; i++)
            printMnemonicsInternal(prefix + possibleChars[i], remainingPhoneNumber.slice(1));
    }
}

var output = printMnemonics("2");
console.log(output);
//for(var index = 0, len = output.length; index<length; index++ )
//console.log(output[index]);