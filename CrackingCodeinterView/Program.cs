using System;

namespace CrackingCodeinterView
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Arrays And Strings Cracking The Code Interview

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

            /*6*/

            string result = ArraysAndStringsSolutions.compress("aabcccccaaa");
             result = ArraysAndStringsSolutions.compress("abcdd");
            Console.WriteLine(result);
            Console.ReadLine();

            /**/

        }


    }
}


