using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersCounter
{
    public class FilteringOperation : IOperation
    {
       
        public char operationType { get ;}  = 'b';

        public string ChooseOperation(string input)
        {
            string enteredString = input;
            char[] enteredCharString = input.ToCharArray();
            string result = string.Empty;

            for (int i = 0; i < enteredString.Length; i++)
            {
                if (!result.Contains(enteredString[i]))
                {
                    result = result + enteredCharString[i];
                }

            }
            return result;
        }
    }
}
