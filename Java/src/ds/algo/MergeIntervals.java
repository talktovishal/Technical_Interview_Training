package src.ds.algo;
import java.util.*;

public class MergeIntervals
{
	 //Definition for an interval.
	 public class Interval {
		 int start;
		 int end;
		 Interval() { start = 0; end = 0; }
		 Interval(int s, int e) { start = s; end = e; }
	 }
	 //this is a VERY tricky question.
	 //this is the most elegant solution. 
	 //http://www.programcreek.com/2012/12/leetcode-insert-interval/
    public ArrayList<Interval> insert(ArrayList<Interval> intervals, Interval newInterval) {
 
        ArrayList<Interval> result = new ArrayList<Interval>();
 
        for(Interval interval: intervals)
		{
            if(interval.end < newInterval.start){
                result.add(interval);
            }else if(interval.start > newInterval.end){
                result.add(newInterval);
                newInterval = interval; //this is the trick!!!
            }else if(interval.end >= newInterval.start || interval.start <= newInterval.end){
                newInterval = new Interval(Math.min(interval.start, newInterval.start), Math.max(newInterval.end, interval.end));
            }
        }
 
        result.add(newInterval); 
 
        return result;
    }
}
