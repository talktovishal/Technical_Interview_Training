using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_CSharp.Lecture2 {
    public static partial class MyExtensions {
        public static string MySubString(this string s, int start, int end)
        {
            return s.Substring(start, end - start + 1);
        }
    }


    class Permutations {


        public static List<string> GetPermutations(string s)
        {
            if (s.Length == 2) { //recussion base case
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0}{1}", (char)s[1], (char)s[0]);
                return new List<string>() { s, sb.ToString() };
            }
            List<string> perms_n = new List<string>();
            char ch = s[0];
            List<string> perms_n_1 = GetPermutations(s.Substring(1, s.Length - 1));
            foreach (var str in perms_n_1) {
                int length = str.Length;
                for (int i = 0; i <= length; i++) {
                    perms_n.Add(str.Substring(0, i) + ch + str.Substring(i, length - i));
                }
            }
            return perms_n;
        }




        public static void swap(char[] array, int x, int y)
        {
            char temp = array[x];
            array[x] = array[y];
            array[y] = temp;
        }

        public static List<string> GetPermutations2(char[] str, int startIndex, int length)
        {
            if (length == 1) { //recussion base case
                return new List<string>() { string.Join("", str[startIndex]) };
            }
            List<string> allPerms = new List<string>();
            for (int i = startIndex; i < length + startIndex; i++) {
                swap(str, startIndex, i);
                foreach (var item in GetPermutations2(str, startIndex + 1, length - 1)) {
                    allPerms.Add(string.Join("", str[startIndex], item));
                }
                swap(str, i, startIndex);
            }
            return allPerms;
        }



        public static List<string> GetPermutationsDups(char[] str, int startIndex, int length)
        {
            if (length == 1) { //recussion base case
                return new List<string>() { string.Join("", str[startIndex]) };
            }
            List<string> allPerms = new List<string>();
            for (int i = startIndex; i < length + startIndex; i++) {
                //So, we just need to see the previous element which we we fixed (and permuted others)
                //if current element is same as previous, don't permute.
                if (i != startIndex && str[startIndex] == str[i])
                    continue;

                swap(str, startIndex, i);
                foreach (var item in GetPermutationsDups(str, startIndex + 1, length - 1)) {
                    allPerms.Add(string.Join("", str[startIndex], item));
                }
                swap(str, i, startIndex);
            }
            return allPerms;
        }




        /*
         * This does not work: ABA
         *  4
            ABA
            BAA
            AAB
            ABA
            across different substrings they need to be distinct.
         */
        public static List<string> GetPermutationsDuplicates(string s)
        {
            if (s.Length == 2) { //recussion base case
                if (s.Distinct().Count() == 2) {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("{0}{1}", (char)s[1], (char)s[0]);
                    return new List<string>() { s, sb.ToString() };
                } else {
                    return new List<string>() { s };
                }
            }
            List<string> perms_n = new List<string>();
            char ch = s[0];
            List<string> perms_n_1 = GetPermutationsDuplicates(s.Substring(1, s.Length - 1));
            foreach (var str in perms_n_1) {
                int length = str.Length;
                for (int i = 0; i <= length; i++) {
                    string suffix = str.Substring(i, length - i);
                    if (suffix.Length > 0 && ch == suffix[0])
                        continue;
                    perms_n.Add(str.Substring(0, i) + ch + suffix);
                }
            }
            return perms_n;
        }




        //The trick is to sort the characters in the alphabetical order first. 
        //We can then ignore the duplicates easily when generate the permutation.
        public static List<string> GetPermutationsDuplicates2(string prefix, string rest)
        {
            List<string> allPerms = new List<string>();
            if (rest.Length == 0) {
                return new List<string>() { prefix };
            } else {
                for (int i = 0; i < rest.Length; i++) {
                    if (i > 0) {
                        if (rest[i] == rest[i - 1]) {
                            continue;
                        }
                    }
                    //perms_n.Add(str.Substring(0, i) + ch + str.Substring(i, length - i));
                    allPerms.AddRange
                        (
                            GetPermutationsDuplicates2(rest.MySubString(0, i) + rest.MySubString(i + 1, rest.Length), prefix + rest[i])
                        );
                }
            }
            return allPerms;
        }


        public static List<string> GetPermutationsDupes3(string s)
        {
            if (s.Length == 2) { //recussion base case
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0}{1}", (char)s[1], (char)s[0]);
                return new List<string>() { s, sb.ToString() };
            }
            List<string> perms_n = new List<string>();
            char ch = s[0];
            List<string> perms_n_1 = GetPermutationsDupes3(s.Substring(1, s.Length - 1));
            foreach (var str in perms_n_1) {
                int length = str.Length;
                for (int i = 0; i <= length; i++) {
                    perms_n.Add(str.Substring(0, i) + ch + str.Substring(i, length - i));
                }
            }
            return perms_n;
        }

        public static void printDuplicates(String str, String prefix)
        {
            if (str.Length == 0) {
                Console.WriteLine(prefix);
            } else {
                for (int i = 0; i < str.Length; i++) {
                    if (i > 0) {
                        if (str[i] == str[i - 1]) {
                            continue;
                        }
                    }

                    printDuplicates(str.MySubString(0, i) + str.MySubString(i + 1, str.Length), prefix + str[i]);
                }
            }
        }

    }
}
