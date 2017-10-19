using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Flow_String
{
    public class StringManipulation
    {
        public string MainString;
        public string FindWord(int nth)
        {
            string result = null;
            var str = MainString.Trim();
            //split string to separate words, remove the empty words
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', ';' };
            string[] array = str.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

            while (array.Length < nth)
            {
                Console.WriteLine("Inputed string is less than" + nth + " words. Please input again.");
                str = Console.ReadLine();
                array = str.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            }
            result = array[nth-1];
            return result;
        }

        public void PrintString()
        {
            string output = null;
            for (int i = 0; i < 10; i++)
            {
                output += (i + 1).ToString() + "." + MainString + ", ";
            }
            output = output.Substring(0, output.Length - 2);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
