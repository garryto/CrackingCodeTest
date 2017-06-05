using System;
namespace CrackingCodeinterView
{
    public static class ArraysAndStringsSolutions
    {
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
    }
}
