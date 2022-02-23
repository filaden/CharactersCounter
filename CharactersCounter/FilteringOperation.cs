using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersCounter
{
    public class FilteringOperation : IFilterOperation
    { 

        public string Filter( string input)
        {
            string enteredString = input; ;
           
            char[] enteredCharString = enteredString.ToCharArray();
            string result = string.Empty;

            for (int i = 0; i < enteredString.Length; i++)
            {
                if (!result.Contains(enteredString[i]))
                {
                    result = result + enteredCharString[i];
                }

            }
            Console.WriteLine(result);
            return input;
        }
    }
}
