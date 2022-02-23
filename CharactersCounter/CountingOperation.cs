using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersCounter
{
    internal class CountingOperation : IOperation
    {
        public char operationType { get; } = 'a';
        
        public string ChooseOperation(string input)
        {
            char[] enteredCharString = input.ToCharArray();
            char ch;
            int count;
            for (ch = (char)97; ch <= 122; ch++)
            {
                count = 0;

                for (int i = 0; i < enteredCharString.Length; i++)
                {
                    if (ch == enteredCharString[i] || (ch + 32) == enteredCharString[i])
                    {
                        count++;
                    }
                }
                if (count > 0)
                {
                    Console.Write(ch + "" + count);
                }
            }
            return input;
        }
    }
}
