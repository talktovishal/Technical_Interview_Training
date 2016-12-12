using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_CSharp.Lecture2
{
	/*
	 * A set of buildings facing west. They are in a straight line and any building that's 
	 * is to the east of a building of equal or greater height cannot view the sunset.
	 * 
	 * Which are the buildings from which you can view the sunset?
	 * The input is processed from order east to west.
	 * 
	 * Brute force: 
	 * let's say the input = 7 5 3 2 1 4 2 1
	 * Store them in an array. Now go from max to 0. 
	 * Store max value. Now update max. If you encounter a value less than 
	 * the max then it means the building doesn't have aa view else it does.
	 * in the example above = 1, 2, 4 (have a view), max = 4, then next views = 5, 7
	 * Time = O(N), space = O(N)
	 * 
	 * Can you do better?
	 * Say if you have a stack. 
	 * push (7), push (5) only if it is LESS than the value on the top. pop(3,2,1) Now you get 4
	 * Now this value is greater than the one in the top. SO pop until you reach a value 
	 * that is until a value greater than 4. 
	 * 
	 * Time complexity although seems like it is higher time complexity but each value is pushed 
	 * or popped at most one hence we are ok :)
	 *  
	 */
    class ComputeBuildingsWithSunset {


    }
}
