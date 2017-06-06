using System;

namespace CrackingCodeinterView
{
    class MainClass
    {
        public static void Main(string[] args)
        {
          

            #region "Arrays And Strings Cracking The Code Interview"
            
            /* 1
			string strValor = "Aldo";

			bool result = ArraysAndStringsSolutions.isUniqueString(strValor);

			if (result)
				Console.WriteLine("true");
			else
				Console.WriteLine("false");
           */

            /*2
            string s1 = "olda";
            string s2 = "aldo";

            bool result = ArraysAndStringsSolutions.permutation(s1,s2);

            result = ArraysAndStringsSolutions.permutationSol2(s1, s2);

            if (result)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            Console.ReadLine();
            */

            /*3
            string str = "Esto huele hasta el perno";
            ArraysAndStringsSolutions.replaceSpaces(str.ToCharArray(),25);
            Console.ReadLine();
            */


            /*4 Permutation of Palindrome 
            string s = "apmlamalooa";
            //string s = "apmlamalloa";
            //bool result = ArraysAndStringsSolutions.isPermutationOfPalindrome(s);
            //bool result = ArraysAndStringsSolutions.isPermutationOfPalindromeSol2(s);
            bool result = ArraysAndStringsSolutions.isPermutationOfPalindromeSol3(s);
            if (result)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            Console.ReadLine();
            */

            /*5 
            bool result = ArraysAndStringsSolutions.oneEditAway("pale", "plie");
            if (result)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            Console.ReadLine();
            */

            /*6

            string result = ArraysAndStringsSolutions.compress("aabcccccaaa");
             result = ArraysAndStringsSolutions.compress("abcdd");
            Console.WriteLine(result);
            Console.ReadLine();

            */

            /*7 
            int[][] matrix = new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8 },new int[] { 9, 10, 11, 12 }, new int[] { 13, 14, 15, 16 } };
            bool result = ArraysAndStringsSolutions.rotate(matrix);
            if (result)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            Console.ReadLine();
          

            */

            /*8
            int[][] matrix = new int[][] { new int[] { 1, 2, 0, 4 }, new int[] { 5, 6, 7, 8 }, new int[] { 9, 0, 11, 12 }, new int[] { 13, 14, 15, 16 } };
            ArraysAndStringsSolutions.setZeros(matrix);
            Console.ReadLine();
            */

            /*9*/
            string s1 = "waterbottle";
            string s2 = "erbortlewat";

            bool result = ArraysAndStringsSolutions.isRotation(s1,s2);
            if (result)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            Console.ReadLine();
            /**/

            #endregion

        }


    }
}


