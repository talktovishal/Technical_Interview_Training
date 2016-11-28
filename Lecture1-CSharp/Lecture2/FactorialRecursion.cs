using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_CSharp.Lecture2 {
    class FactorialRecursion {

        public static ulong GetFactorialv1(ulong n)
        {
            return GetFactorialv1Internal(n, 1);
        }

        private static ulong GetFactorialv1Internal(ulong n, 
            ulong product)
        {
            if (n == 1 || n == 0)
                return 1 * product;
            else {
                return GetFactorialv1Internal(n - 1, 
                    product * n);
            }
        }

        public static ulong GetFactorialv2(ulong n)
        {
            if (n == 1 || n == 0)
                return 1;
            else {
                return n * GetFactorialv2(n - 1);
            }
        }


        public static ulong GetFactorialv3(ulong n)
        {
            ulong product = 1;
            while (n > 1)
                product *= (n--);
            return product;
        }


    }
}
