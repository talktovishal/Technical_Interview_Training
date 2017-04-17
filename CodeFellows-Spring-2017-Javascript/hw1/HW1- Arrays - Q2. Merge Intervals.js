class Interval {
    constructor() {
        this.start = -1;
        this.end = -1;
    }

    setValues(start, end) {
        this.start = start;
        this.end = end;
    }
}

function Insert(intervals, newInterval) {

    var result = [];
    var index = 0;
    for (var i = 0; i < intervals.length; i++) {
        //console.log(index);
        var interval = intervals[i];
        //no overlap: the new interval is after the current one.        
        if (interval.end < newInterval.start) {
            result[index++] = interval;
        }
            //no overlap: the existing interval is after the new interval.        
        else if (interval.start > newInterval.end) {
            result[index++] = newInterval;
            newInterval = interval;
        }
            //potential overlap (1,5) & (2,3)
        else if (interval.end >= newInterval.start || interval.start <= newInterval.end) {
            createNewInterval = new Interval();
            createNewInterval.setValues(
                                    Math.min(interval.start, newInterval.start),
                                    Math.max(newInterval.end, interval.end)
                                  );
            newInterval = createNewInterval;
        }
    }
    //console.log(index);
    result[index++] = newInterval;

    return result;
}

function Print(intervals) {
    for (var i = 0; i < intervals.length; i++) {
        console.log(intervals[i].start + "," + intervals[i].end);
    }

}
/*
//Insert([1,5], [8,9] insert and merge [6,7] would result in [1,5], [6,7], [8,9].

var i1 = new Interval(); i1.setValues(1,5);
var i2 = new Interval(); i2.setValues(6,7);
var intervals = [i1, i2];
var i3 = new Interval(); i3.setValues(8,9);
Print(Insert(intervals, i3))
*/

/*
var i1 = new Interval(); i1.setValues(1,5);
var i2 = new Interval(); i2.setValues(8,9);
var intervals = [i1, i2];
var i3 = new Interval(); i3.setValues(6,7);
Print(Insert(intervals, i3))
*/

/*
Given intervals [1,5], [8,9] insert and merge [2,3] would result in [1,5], [8,9].
Given intervals [1,5], [8,9] insert and merge [6,8] would result in [1,5], [6,9].
*/

/*
Given intervals [1,5], [8,9] insert and merge [2,3] would result in [1,5], [8,9].
*/
var i1 = new Interval(); i1.setValues(1, 5);
var i2 = new Interval(); i2.setValues(8, 9);
var intervals = [i1, i2];
var i3 = new Interval(); i3.setValues(2, 3);
Print(Insert(intervals, i3))

/*
Given intervals [1,5], [8,9] insert and merge [6,8] would result in [1,5], [6,9].
*/
var i4 = new Interval(); i4.setValues(1, 5);
var i5 = new Interval(); i5.setValues(8, 9);
var intervals = [i4, i5];
var i6 = new Interval(); i6.setValues(6, 8);
Print(Insert(intervals, i6))
