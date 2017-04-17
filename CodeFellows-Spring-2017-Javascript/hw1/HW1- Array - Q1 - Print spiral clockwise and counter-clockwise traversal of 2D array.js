function spiralOrder(matrix, m, n) {
    if (m === 0 || n === 0)
        return;

    var top = 0;
    var left = 0;

    var down = m - 1;
    var right = n - 1;

    while (true) {
        // print top row
        for (var j = left; j <= right; ++j) console.log(matrix[top][j]);
        top++;
        if (top > down) break;

        //print the rightmost column
        for (var i = top; i <= down; ++i) console.log(matrix[i][right]);
        right--;
        if (left > right) break;

        //print the bottom row
        for (var k = right; k >= left; --k) console.log(matrix[down][k]);
        down--;
        if (top > down) break;

        //print the leftmost column
        for (var l = down; l >= top; --l) console.log(matrix[l][left]);
        left++;
        if (left > right) break;
    }
}


var input = [[1, 2, 3, 4],
            [5, 6, 7, 8],
            [9, 10, 11, 12],
            [13, 14, 15, 16]];

spiralOrder(input, 4, 4)