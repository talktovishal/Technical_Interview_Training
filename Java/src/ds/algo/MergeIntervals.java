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
	 //The idea is consider 3 cases, case 1: the new interval is before the current, case 2: it's afterwards
	 //case3: it's inbetween -- is it consumed, does it consume the new interval or is there a case where A u B > A and > B
    public ArrayList<Interval> insert(ArrayList<Interval> intervals, Interval newInterval) {
 
        ArrayList<Interval> result = new ArrayList<Interval>();
		
		//you have to draw a picture to understand what's going on. 
        for(Interval current: intervals)
		{
            if(current.end < newInterval.start){
                result.add(current);
            }else if(current.start > newInterval.end){
                result.add(newInterval);
                newInterval = current; //trick!!!
				//this is the most important line, you essentially reset the newInterval object. 
				//the idea is to make the newInterval adding work at the end.
            }else if(current.end >= newInterval.start || current.start <= newInterval.end){
				//again update the new interval, don't add it yet since it may be overlapping in what comes later.
                newInterval = new Interval(Math.min(current.start, newInterval.start), Math.max(newInterval.end, current.end));
            }
        }
		
        result.add(newInterval); 
 
        return result;
    }
}
