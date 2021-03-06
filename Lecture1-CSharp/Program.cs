﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture1_CSharp.Lecture1.Arrays;
using Lecture1_CSharp.Lecture2;
using Lecture1_CSharp.Lecture3_Searching;
using Lecture1_CSharp.Lecture3_Sorting;
using Lecture1_CSharp.Lecture1.String;
using Lecture1_CSharp.Lecture1;

namespace Lecture1_CSharp {
    public class Program {

        public static void BuildString()
        {
            string sb1 = "";
            for (int i = 0; i < 100; i++) {
                sb1 += i;
            }
            StringBuilder sb2 = new StringBuilder("");
            for (int i = 0; i < 100; i++) {
                sb2.Append(i);
            }
            Console.WriteLine(sb1);
            Console.WriteLine(sb2);
        }


        static void PrintSeparator(object name)
        {
            //BuildString();
            Console.WriteLine(string.Empty);
            Console.WriteLine("****     {0}     ****", name);
        }

        public static void TestAlgorithmComplexity()
        {
            //C# only, Java has just one.
            int[,,] multidimensionalArray = new int[4, 2, 3];
            //in C# Jagged arrays are faster.
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];


            //BubbleSort.Run(new int[] { 1, 3, 5, 6, 2, 4, 8, 2, 4, 6, 8, 3 });
            PrintSeparator(typeof(ThreeSum));
            ThreeSum.Run(new int[] { -2, -1, 0, 1, 2, 3, -4 });
            PrintSeparator(typeof(ThreeSumFast));
            ThreeSumFast.Run(new int[] { -2, -1, 0, 1, 2, 3, -4 });
            PrintSeparator(typeof(DeleteDuplicateExtraSpace));
            DeleteDuplicateExtraSpace.Run(new int[] { 6, 1, 2, 2, 3, 4, 2, 5, 6, 6, 7, 4, 9, 6 });
            PrintSeparator(typeof(DeleteDuplicateConstantSpace));
            DeleteDuplicateConstantSpace.Run(new int[] { 6, 1, 2, 2, 3, 4, 2, 5, 6, 6, 7, 4, 9, 6 });
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("****         Main        ************");
            //TestLongestInteger();
            //TestSpiral();
            //TestDuplicate();
            //TestMissingPositive();
            //TestFactorial();
            //TestPermutations();
            //TestGetPermutationsDuplicates();
            //TestBinarySearchCounts();
            //TestSorts();
            //TestStringPhoneNumber();
            TestRleEncoding();
        }

        //RleEncoding
        private static void TestRleEncoding()
        {
            Console.WriteLine(RleEncoding.Encode("aaaabcccaa"));
            Console.WriteLine(RleEncoding.Encode("eeeffffee"));
            Console.WriteLine(RleEncoding.Encode("a"));
            Console.WriteLine(RleEncoding.Encode("abbcccd"));
            Console.WriteLine(RleEncoding.Encode("abbcccddddeeeeef"));

            //Console.WriteLine(RleEncoding.Decode("4a1b3c2a"));
            //Console.WriteLine(RleEncoding.Decode("3e4f2e"));
        }

        private static void TestStringPhoneNumber()
        {
            StringPhoneNumber.PrintPhoneNumber(new int[] { 0, 1, 2, 3, 4 });
        }

        private static void TestSorts()
        {
            List<int> unsortedList = new List<int>() { 1, 3, 5, 6, 2, 4, 8, 2, 4, 6 };
            var unsortedA = unsortedList.ToArray<int>();

            List<int> unsortedList2 = new List<int>() { 3 };
            var unsorted2A = unsortedList2.ToArray<int>();

            List<int> unsortedList3 = new List<int>() { 3, 3, 3, 3, 3, 3 };
            var unsorted3A = unsortedList3.ToArray<int>();

            Mergesort.Run(unsortedA);
            Mergesort.Run(unsorted2A);
            Mergesort.Run(unsorted3A);

            //test
            foreach (var item in new List<int[]>() { unsortedA, unsorted2A, unsorted3A }) {
                for (int i = 0; i < item.Length - 2; i++) {
                    if (item[i] > item[i + 1]) {
                        throw new ApplicationException("sort failed.");
                    }
                }
            }
        }

        private static void TestBinarySearchCounts()
        {
            Console.WriteLine(AllPossibleElements.BinarySearch(new List<int>() { 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 4, 4, 5, 5, 5, 5, 5, 6, 6, 6, 7, 7, 8, 8, 8, 8, 9, 9, 10, 10, 10 }, 1));
            Console.WriteLine(AllPossibleElements.TotalCount(new List<int>() { 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 4, 4, 5, 5, 5, 5, 5, 6, 6, 6, 7, 7, 8, 8, 8, 8, 9, 9, 10, 10, 10 }, 1));
        }

        private static void TestFactorial()
        {
            Console.WriteLine(FactorialRecursion.GetFactorialv1(50));
            Console.WriteLine(FactorialRecursion.GetFactorialv2(50));
            Console.WriteLine(FactorialRecursion.GetFactorialv3(50));
        }

        private static void TestPermutations()
        {
            var permutations = Permutations.GetPermutationsDups("AABC".ToCharArray(), 0, "AABC".Length);
            Console.WriteLine(permutations.Count);
            foreach (var item in permutations) {
                Console.WriteLine(item);
            }
        }

        private static void TestGetPermutationsDuplicates()
        {
            string s = string.Join("", "ABA".OrderBy(c => c));
            var permutations = Permutations.GetPermutationsDuplicates(s);
            Console.WriteLine(permutations.Count);
            foreach (var item in permutations) {
                Console.WriteLine(item);
            }
        }


        private static void TestMissingPositive()
        {
            SmallestPositiveNumberModifyArray sm = new SmallestPositiveNumberModifyArray();
            //Console.WriteLine(sm.firstMissingPositive(new List<int>() {-1,2,3,4 }));
            //Console.WriteLine(sm.firstMissingPositive(new List<int>() { -1, 7, 2, 6, 3, 1, 4 }));
            //Console.WriteLine(sm.firstMissingPositive(new List<int>() { 417, 929, 845, 462, 675, 175, 73, 867, 14, 201, 777, 407, 80, 882, 785, 563, 209, 261, 776, 362, 730, 74, 649, 465, 353, 801, 503, 154, 998, 286, 520, 692, 68, 805, 835, 210, 819, 341, 564, 215, 984, 643, 381, 793, 726, 213, 866, 706, 97, 538, 308, 797, 883, 59, 328, 743, 694, 607, 729, 821, 32, 672, 130, 13, 76, 724, 384, 444, 884, 192, 917, 75, 551, 96, 418, 840, 235, 433, 290, 954, 549, 950, 21, 711, 781, 132, 296, 44, 439, 164, 401, 505, 923, 136, 317, 548, 787, 224, 23, 185, 6, 350, 822, 457, 489, 133, 31, 830, 386, 671, 999, 255, 222, 944, 952, 637, 523, 494, 916, 95, 734, 908, 90, 541, 470, 941, 876, 264, 880, 761, 535, 738, 128, 772, 39, 553, 656, 603, 868, 292, 117, 966, 259, 619, 836, 818, 493, 592, 380, 500, 599, 839, 268, 67, 591, 126, 773, 635, 800, 842, 536, 668, 896, 260, 664, 506, 280, 435, 618, 398, 533, 647, 373, 713, 745, 478, 129, 844, 640, 886, 972, 62, 636, 79, 600, 263, 52, 719, 665, 376, 351, 623, 276, 66, 316, 813, 663, 831, 160, 237, 567, 928, 543, 508, 638, 487, 234, 997, 307, 480, 620, 890, 216, 147, 271, 989, 872, 994, 488, 291, 331, 8, 769, 481, 924, 166, 89, 824, -4, 590, 416, 17, 814, 728, 18, 673, 662, 410, 727, 667, 631, 660, 625, 683, 33, 436, 930, 91, 141, 948, 138, 113, 253, 56, 432, 744, 302, 211, 262, 968, 945, 396, 240, 594, 684, 958, 343, 879, 155, 395, 288, 550, 482, 557, 826, 598, 795, 914, 892, 690, 964, 981, 150, 179, 515, 205, 265, 823, 799, 190, 236, 24, 498, 229, 420, 753, 936, 191, 366, 935, 434, 311, 920, 167, 817, 220, 219, 741, -2, 674, 330, 909, 162, 443, 412, 974, 294, 864, 971, 760, 225, 681, 689, 608, 931, 427, 687, 466, 894, 303, 390, 242, 339, 252, 20, 218, 499, 232, 184, 490, 4, 957, 597, 477, 354, 677, 691, 25, 580, 897, 542, 186, 359, 346, 409, 655, 979, 853, 411, 344, 358, 559, 765, 383, 484, 181, 82, 514, 582, 593, 77, 228, 921, 348, 453, 274, 449, 106, 657, 783, 782, 811, 333, 305, 784, 581, 746, 858, 249, 479, 652, 270, 429, 614, 903, 102, 378, 575, 119, 196, 12, 990, 356, 277, 169, 70, 518, 282, 676, 137, 622, 616, 357, 913, 161, 3, 589, 327 }));
            //Console.WriteLine(sm.firstMissingPositive(new List<int>() { 948, 20, 84, 710, 471, 606, 995, 581, -4, 428, 149, 832, 740, 943, 450, 974, 829, 721, 821, 476, 763, 4, 523, 937, 814, 624, 935, 87, 127, 816, 239, 33, 561, 999, 904, 282, 844, 923, 750, 551, 432, 9, 373, 387, 114, 376, 265, 801, 228, 454, 474, 764, 268, 680, 472, 431, 133, 785, 752, 643, 441, 151, 969, 395, 437, 94, 259, 973, 535, 272, 456, 546, 79, 677, 0, 109, 522, 295, 466, 956, 723, 157, 772, 865, 997, 771, 922, 980, 567, 939, 651, 478, 852, 926, 913, 494, 882, 207, 915, 645, 754, 385, 874, 554, 706, 722, 10, 374, 96, 647, 280, 418, 737, 538, 867, 850, 600, 23, 730, 742, 224, 511, 361, 251, 809, 907, 271, 319, 866, 848, 594, 566, 113, 211, 334, 644, 826, 430, 929, 603, 165, 147, 788, 529, 539, 633, 275, 602, 544, 540, 853, 123, -1, 443, 942, 386, 68, 465, 782, 250, 458, 174, 70, 919, 462, 347, 26, 589, 880, 648, 237, 294, 641, 707, 516, 507, 802, 989, 779, 519, 62, 619, 584, 358, 362, 277, 43, 198, 467, 625, 611, 212, 468, 767, 778, 173, 791, 331, 11, 461, 572, 97, 902, 558, 413, 28, 179, 370, 842, 568, 500, 311, 550, 464, 345, 411, 274, 181, 396, 339, 39, 760, 575, 327, 889, 579, 840, 734, 254, 934, 532, 29, 622, 780, 73, 479, 322, 2, 599, 227, 685, 65, 510, 716, 289, 912, 574, 262, 916, 924, 304, 57, 353, 40, 341, 521, 131, 307, 526, 398, 225, 63, 776 }));
            Console.WriteLine(sm.firstMissingPositive(new List<int>() { 178, 857, 624, 860, 1, 802, 985, 483, 395, 378, 166, 468, 94, 5, 762, 892, 350, 35, 812, 204, 252, 12, 174, 362, 210, 88, 244, 79, 36, 778, 953, 637, 193, 836, 473, 842, 434, 960, 260, 118, 724, 184, 322, 330, 528, 974, 134, 864, 745, 82, 449, 939, 938, 44, 575, 627, 436, 154, 410, 840, 859, 853, 230, 884, 631, 954, 351, 549, 285, 319, 336, 422, 861, 275, 108, 760, 671, 527, 305, 340, 249, 705, 552, 480, 822, 349, 464, 949, 90, 531, 127, 223, 854, 713, 775, 191, 697, 761, 766, 300, 206, 665, 566, 845, 484, 364, 520, 384, 342, 801, 68, 441, 107, 595, 885, 418, 908, 64, 577, 332, 711, 315, 525, 216, 867, 63, 281, 924, 674, 19, 582, 608, 958, 683, 457, 3, 526, 467, 10, 730, 716, 810, 634, 814, 786, 386, 168, 862, 451, 511, 221, 590, 318, 708, 114, 992, 472, 286, 507, 97, 739, 727, 536, 809, 17, 559, 307, 312, 454, 693, 866, 818, 31, 871, 732, 834, 9, 30, 846, 200, 188, 427, 27, 852, 199, 524, 132, 76, 773, 580, 469, 770, 779, 438, 828, 341, 394, 725, 755, 763, 128, 4, 180, 240, 759, 897, 934, 564, 32, 820, 56, 459, 314, 367, 298, 687, 571, 808, 279, 39, 749, 546, 890, 194, 662, 748, 606, 84, 906, 737, 224, 379, 752, 352, 101, 756, 917, 304, 294, 356, 411, 112, 843, 562, 388, 735, 615, 339, 198, 158, 930, 518, 186, 235, 479, 515, 824, 994, 681, 431, 348, 95, 273, 782, 53, 835, 943, 140, 502, 420, 689, 428, 404, 470, 793, 659, 714, 155, 629, 965, 41, 478, 797, 503, 171, 429, 490, 447, 851, 276, 104, 976, 261, 267, 940, 366, 325, 237, 443, 417, 720, 618, 881, 918, 264, 909, 416, 18, 369, 709, 137, 971, 611, 831, 207, 768, 987, 219, 363, 266, 589, 2, 402, 545, 89, 723, 169, 492, 599, 551, 633, 596, 690, 612, 794, 785, 72, 817, 382, 40, 152, 848, 922, 655, 813, 574, 641, 638, 310, 98, 334, 432, 29, 509, 57, 513, 988, 8, 66, 678, 951, 110, 465, 800, 576, 164, 876, 815, 955, 767, 190, 517, 873, 329, 15, 710, 696, 875, 962, 533, 935, 530, 726, 25, 326, 510, 721, 187, -5, 832, 256, 242, 701, 717, 196, 664, 623, 788, 290, 795, 214, 425, 841, 741, 695, 308, 268, 274, 179, 932, 316, 103, 604, 135, 874, 189, 656, 412, 139, 698, 837, 47, 650, 211, 46, 372, 359, 61, 401, 986, 879, 270, 289, 150, 292, 896, 119, 984, 907, 645, 521, 902, 277, 811, 407, 499, 393, 49, 77, 424, 833, 568, 33, 295, 544, 6, 385, 311, 148, 747, 619, 253, 587, 197, 80, 272, 972, 957, 65, 450, 106, 556, 825, 442, 877, 855, 233, 523, 460, 133, 291, 968, 426, 588, 539, 804, 147, 561, 989, 597, 209, 870, 320, 636, 344, 578, 733, 380, 283, 929, 232, 894, 942, 497, 666, 177, 185, 783, 167, 287, 437, 243, 719, 476, 648, 409, 213, 160, 920, 144, -3, 740, 757, 898, 131, 796, 71, 781, 569, 496, 313, 973, 327, 306, 282, 48, 999, 993, 343, 905, 882, 573, 62, 217, 500, 365, 73, 543, 257, 878, 895, 122, 982, 324, 381, 613, 734, 567, 565, 652, 990, 370, 937, 642, 722, 583, 92, 777, 598, 784, 52, 586, 463, 115, 673, 975, 700, 622, 455, 16, 529, 728, 113, 487, 299, 869, 42, 514, 688, 682, 361, 151, 570, 921, 751, 202, 37, 328, 303, 512, 535, 67, 699, 50, 21, 227, 192, 488, 731, 23, 474, 22, 173, 501, 14, 838, 20, 635, 149, 991, 165, 205, 85, 254, 157, 406, 593, 640, 858, 1000, 26, 75, 337, 826, 170, 996, 456, 558, 182, 415, 703, 660, 331, 338, 691, 215, 374, 466, 136, 368, 51, 780, 45, 729, 74, 485, 839, 143, 284, 661, 59, 102, 333, 887, 602, 175, 977, 548, 262, 754, 669, 769, 396, 54, 130, 58, 594, 628, 376, 391, 439, 900, 508, 581, 764, 430, 11, 353, 919, 614, 948, 116, 676, 657, 600, 553, 69, 653, 789, 966, 964, 421, 354, 203, 413, 912, 498, 259, 829, 120, 893, 537, 888, 258, 231, 961, 880, 156, 201, 572, 950, 995, 218, 153, 746, 774, 377, 245, 799, 93, 7, 969, 111, 55, 616, 847, 163, 271, 236, 309, 819, 925, 609, 677, 816, 516, 911, 765, 883, 684, 685, 321, 772, 482, 753, 967, 522, 176, 592, 162, 868, 827, 433, 538, 251, 357, 821, 195, 806, 506, 408, 707, 776, 956, 390, 923, 220, 241, 392, 981, 670, 375, 124, 477, 142, 927, 555, 541, 86, 159, 872, 978, 371, 680, 679, 239, 398, 234, 667, 400, 823, 250, 263, 462, 617, 771, 129, 643, 212, 288, 505, 461, 941, 997, 96, 81, 563, 126, -2, 692, 246, 540, 946, 639, 229, 226, 798, 945, 915, 172, 302, -1, 534, 959, 161, 405, 403, 658, 654, 863, 532, 736, 913, 491, 579, 718, 269, 100, 486, 632, 494, 931, 844, 850, 125, 620, 444, 787, 475, 141, 791, 663, 607, 651, 495, 123, 625, 979, 83, 712, 550, -4, 560, 702, 228, 355, 865, 944, 99, 452, 792, 225, 743, 998, 856, 738, 280, 750, 519, 60, 265, 323, 610, 901, 347, 916, 146, 675, 704, 238, 983, 584, 542, 105, 926, 458, 910, 91, 963, 807, 43, 248, 360, 790, 0, 181, 830, 672, 591, 399, 121, 440, 278, 686, 886, 297, 423, 435, 744, 603, 891, 145, 649, 13, 647, 446, 585, 481, 34, 952, 346, 970, 28, 419, 933, 24, 947, 557, 904, 222, 117 }));
        }

        public static void TestDuplicate()
        {
            DuplicateInArray dup = new DuplicateInArray();
            Console.WriteLine(dup.repeatedNumber(new List<int>() { 3, 4, 1, 4, 1 }));
        }

        public static void TestLongestInteger()
        {
            LargesNumberString ls = new LargesNumberString();
            //Console.WriteLine(ls.largestNumber(new List<int>() { 3, 9, 95 }));
            //Console.WriteLine(ls.largestNumber(new List<int>() { 5, 9, 95 }));
            //3,   
            //Console.WriteLine(ls.largestNumber(new List<int>() { 30, 5, 9, 95}));
            Console.WriteLine(ls.largestNumber(new List<int>() { 9, 99, 999, 9999, 9998 }));
            //Console.WriteLine(ls.largestNumber(new List<int>() { 8, 89 }));
            //9534330
            //95533430
        }


        public static void TestSpiral()
        {
            List<List<int>> A = new List<List<int>>();
            A.Add(new List<int>() { 1, 2, 3 });
            A.Add(new List<int>() { 4, 5, 6 });
            //A.Add(new List<int>() { 7, 8, 9 });
            PrintSpiral p = new PrintSpiral();
            Console.WriteLine(string.Join(",", p.spiralOrder(A)));

            List<List<int>> B = new List<List<int>>();
            B.Add(new List<int>() { 0, 157, 290, 113, 119, 118, 187, 360, 104, 365, 197, 103, 355, 240, 337, 174, 138, 252, -1 });
            Console.WriteLine(string.Join(",", p.spiralOrder(B)));

        }
    }
}
