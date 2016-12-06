using System;
//using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_CSharp.Lecture1.Arrays {

    //Need Sorting.
    class LargesNumberString {
        //Given [3, 30, 34, 5, 9], the largest formed number is 9534330.
        public string largestNumber(List<int> A)
        {
            List<string> array = new List<string>();
            foreach (var item in A) {
                array.Add(item.ToString());
            }
            array.Sort((X, Y) => {
                // first append Y at the end of X
                string XY = X + Y;

                // then append X at the end of Y
                string YX = Y + X;

                // Now see which of the two formed numbers is greater
                return XY.CompareTo(YX)*(-1);
            });
            string ret = string.Join("", array.ToArray<string>());
            if (ret.Replace("0", "") == string.Empty)
                return "0";
            else
                return ret;

        }
    }
}
