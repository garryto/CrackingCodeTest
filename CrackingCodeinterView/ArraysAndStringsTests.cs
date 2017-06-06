using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CrackingCodeinterView
{
    // 9 Questions
    public static class ArraysAndStringsSolutions
    {
        #region "Question1 - Unique chars on String"
        /// <summary>
        /// 1.1 Checks if a string has unique characters.
        /// </summary>
        /// <returns><c>true</c>, if unique string was ised, <c>false</c> otherwise.</returns>
        /// <param name="strVal">String value.</param>
        //Assuming 'a to z' values of the string        
        public static bool isUniqueString(string strVal)
		{
			int checker = 0;
			for (int i = 0; i < strVal.Length; i++)
			{
				int val = strVal[i] - 'a';
				if ((checker & (1 << val)) > 0)
				{

					return false;
				}
				checker |= (1 << val);

			}

			return true;

		}

        #endregion

        #region "Question2 - Permutation"

        public static string ordena(string s)
        {
          
            Stopwatch sw = new Stopwatch();
            sw.Start();
            
            char[] content = s.ToCharArray();
            Array.Sort(content);

            sw.Stop();
            Console.WriteLine("Ordena Elapsed={0} ms", sw.Elapsed);

            return new String(content);
        }

        public static string ordenaLinqConcat(string s)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            string result = String.Concat(s.OrderBy(c => c));

            sw.Stop();
            Console.WriteLine("Ordena LinqConcat Elapsed={0} ms", sw.Elapsed);
            return result;
        }

        public static string ordenaLinq(string s)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            string result = new string (s.OrderBy(c => c).ToArray());

            sw.Stop();
            Console.WriteLine("Ordena LinqNewString Elapsed={0} ms", sw.Elapsed);
            return result;
        }

        public static bool permutation(string s1, string s2)
        {


            Stopwatch sw = new Stopwatch();
            sw.Start();

            if (s1.Length != s2.Length)
                return false;

            //return ordenaLinqConcat(s1).Equals(ordenaLinqConcat(s2)); //+ demoron
            //return ordenaLinq(s1).Equals(ordenaLinq(s2)); //mejor
            bool result =  ordena(s1).Equals(ordena(s2)); //optimo

            sw.Stop();
            Console.WriteLine("permutation simple solution Elapsed={0} ms", sw.Elapsed);

            return result;

        }

        //More Efficient Solutions
        public static bool permutationSol2(string s1, string s2)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            if (s1.Length != s2.Length)
                return false;

            int[] letras = new int[128]; //Asumiendo caracteres ASCII

            char[] sArray = s1.ToCharArray();

            foreach (char c in sArray)
            {
                letras[c]++;
            }

            for (int i=0; i<s2.Length; i++)
            {
                int c = (int)s2[i];

                letras[c]--;

                if (letras[c] < 0)
                {
                    sw.Stop();
                    Console.WriteLine("permutation elaborated solution Elapsed={0} ms", sw.Elapsed);
                    return false;
                }

            }

            sw.Stop();
            Console.WriteLine("permutation elaborated solution Elapsed={0} ms", sw.Elapsed);
            return true;
        }

        #endregion

        #region "Question3 - White Spaces Replacement"

        public static void replaceSpaces(char[] str, int truelength)
        {
            int spacecount = 0, index,i;
            for ( i=0; i< truelength; i++)
            {
                if (str[i] == ' ')
                    spacecount++;
            }
            index = truelength + spacecount * 2;
            char[] strResult = new char[index];

            if (truelength < str.Length) str[truelength] = '\0';

            for ( i = truelength-1;i>=0;i--)
            {
                if (str[i] == ' ')
                {
                    strResult[index - 1] = '0';
                    strResult[index - 2] = '2';
                    strResult[index - 3] = '%';
                    index = index - 3;
                }
                else
                {
                    strResult[index-1] = str[i];
                    index--;
                }
            }

            Console.WriteLine(strResult);
        }

        #endregion

        #region "Question4 - Permutation of Palindrome"
        
        public static bool isPermutationOfPalindrome(string str)
        {
            int[] table = buildCharFrecuencyTable(str);
            return checkMaxOneOdd(table); 
        }

        // This solution is not more efficiente since does not change o(n) complexity
        // It only is a small improve since the verification of oddity is done as
        // we iterate the string phrase.
        public static bool isPermutationOfPalindromeSol2(string str)
        {
            int countOdd = 0;
            int[] table = new int['z' - 'a' + 1];
            foreach (char c in str)
            {
                int x = getCharNumber(c);
                if (x!=-1)
                {
                    table[x]++;
                    if (table[x] % 2 == 1)
                    {
                        countOdd++;
                    } else
                    {
                        countOdd--;
                    }
                }

            }

            return countOdd <= 1;
        }

        //This solution is also O(n), but i think is less memory space.
        public static bool isPermutationOfPalindromeSol3(string str)
        {
            int bitVector = createBitVector(str);
            return bitVector == 0 || checkExactlyOneBitSet(bitVector);

        }

        private static bool checkExactlyOneBitSet(int bitVector)
        {
            //Si solo un caracter queda encendido entonces esta operacion da cero
            return (bitVector & (bitVector - 1)) == 0;
        }

        private static int createBitVector(string str)
        {
            int bitVector = 0;
            
            foreach(char c in str.ToCharArray())
            {
                int x = getCharNumber(c);
                bitVector = toggle(bitVector, x);
            }

            return bitVector;
        }

        private static int toggle(int bitVector, int index)
        {
            if (index < 0) return bitVector;
            int mask = 1 << index;
            if ((bitVector & mask) == 0)
            {
                bitVector |= mask; //Lo prendes al encontrar el caracter por primera vez, osea impar
            }
            else
            {
                bitVector &= ~mask; //Lo apagas al encontrar el caracter por segunda vez, osea par
            }
            return bitVector; //Para que sea valido al final solo un caracter debe quedar encendido.
        }

        private static bool checkMaxOneOdd(int[] table)
        {
            bool foundOdd = false;

            foreach (int i in table)
            {
                if (i%2 == 1)
                {
                    if (foundOdd)
                        return false;
                    foundOdd = true;
                }

            }

            return true;
        }

        private static int[] buildCharFrecuencyTable(string str)
        {
            int[] table = new int['z' - 'a' + 1];
            foreach (char c in str.ToCharArray())
            {
                int x = getCharNumber(c);
                if (x != -1)
                    table[x]++;
            }
            return table;

        }

        private static int getCharNumber(char c)
        {
            int a = 'a';
            int z = 'z';
            int val = c;
            if (a <= val && val <= z)
                return val - a;
            return -1;
        }
        #endregion

        #region "Question5 - One Edit Away"
        public static bool oneEditAway(string s1, string s2)
        {
            if (s1.Length == s2.Length)
                return oneReplacementAway(s1, s2);
            else
                if (s1.Length + 1 == s2.Length)
                return oneInsertAway(s1, s2);
            else
                 if (s1.Length - 1 == s2.Length)
                    return oneInsertAway(s2, s1);

            return false;

        }

        private static bool oneInsertAway(string s1, string s2)
        {
            int index1 = 0;
            int index2 = 0;
            while (index1 <s1.Length && index2<s2.Length)
            {
                if (s1[index1] != s2[index2])
                {
                    if (index1 != index2)
                        return false;
                    index2++;
                }
                else
                {
                    index1++;
                    index2++;
                }
            }

            return true;
        }

        private static bool oneReplacementAway(string s1, string s2)
        {
            bool foundDifference = false;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    if (foundDifference)
                        return false;
                    foundDifference = true;

                }
            }

            return true;
        }

        //TODO: Merge insert and Replace in one method

        #endregion

        #region "Question 6 - Compressed String"

        //TODO: BAD SOLUTION AND STRINGBUILDER SOLUTION

        //This solution checks before building the compressed string instead the other
        //aproaches where the string is compressed and then decided if returned

        public static string compress(string str)
        {
            //Check Final Lenght
            int finalLenght = countCompression(str);
            if (finalLenght >= str.Length)
                return str;
            StringBuilder strCompressed = new StringBuilder(finalLenght);

            int countConsecutive = 0;

            for (int i=0; i< str.Length; i++)
            {
                countConsecutive++;

                if (i+1 >= str.Length || str[i]!=str[i+1])
                {
                    strCompressed.Append(str[i]);
                    strCompressed.Append(countConsecutive);
                    countConsecutive = 0;
                }


            }

            return strCompressed.ToString();
        }

        private static int countCompression(string str)
        {
            int compressedLength = 0;
            int countConsecutive = 0;
            for (int i = 0; i < str.Length; i++)
            {
                countConsecutive++;
                if (i + 1 >= str.Length || str[i] != str[i + 1])
                {
                    compressedLength += 1 + countConsecutive.ToString().Length;
                    countConsecutive = 0;
                }
            }

            return compressedLength;
        }

        #endregion

    }
}
