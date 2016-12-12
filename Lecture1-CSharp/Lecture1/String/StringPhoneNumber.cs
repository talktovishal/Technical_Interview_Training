using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_CSharp.Lecture1.String {

    /* Compute all Mnemonics for a phone number
     * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
     * Basically take in a phone number and output all possible
     * character sequences. They don't have to be valid words.
     */
    class StringPhoneNumber {
        private static Dictionary<int, char[]> mappings = new Dictionary<int, char[]>() {
            [0] = new char[] { '0' },
            [1] = new char[] { '1' },
            [2] = new char[] { 'A', 'B', 'C' },
            [3] = new char[] { 'D', 'E', 'F' },
            [4] = new char[] { 'G', 'H', 'I' },
            [5] = new char[] { 'J', 'K', 'L' },
            [6] = new char[] { 'M', 'N', 'O' },
            [7] = new char[] { 'P', 'Q', 'R', 'S' },
            [8] = new char[] { 'T', 'U', 'V' },
            [9] = new char[] { 'W', 'X', 'Y', 'Z' },
        };


        public static void PrintPhoneNumber(int[] numbers)
        {
            List<char> prefix = new List<char>();
            int total = 0;
            PrintPhoneNumberInternal(prefix, numbers, 0, ref total);
            Console.WriteLine(total);
        }

        private static void PrintPhoneNumberInternal(List<char> prefix, int[] numbers, int currentIndex, ref int total)
        {
            bool isLastIteration = currentIndex == numbers.Length - 1;
            foreach (var ch in mappings[numbers[currentIndex]]) {
                if(isLastIteration) {
                    total++;
                    Console.WriteLine($"{string.Join("", prefix)}{ch}");
                } else {
                    prefix.Add(ch);
                    PrintPhoneNumberInternal(prefix, numbers, currentIndex + 1, ref total);
                    prefix.RemoveAt(prefix.Count - 1);
                }
            }
        }

    }


}
