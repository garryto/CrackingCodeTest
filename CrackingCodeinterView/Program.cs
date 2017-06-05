using System.IO;
using System;

namespace CrackingCodeinterView
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			// Arrays And Strings Cracking The Code Interview

			string strValor = "Aldo";

			bool result = ArraysAndStringsSolutions.isUniqueString(strValor);

			if (result)
				Console.WriteLine("true");
			else
				Console.WriteLine("false");
        }

		
    }
}


