using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersCounter
{
    public class CountingOperation : ICountingOperation
    {
        public string Counting(string input)
        {
            input = input.Replace(" ", string.Empty);

            while (input.Length > 0)
            {
                char letterForCheck = input[0];
                Console.Write(letterForCheck + "");
                int count = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (letterForCheck == input[j])
                    {
                        count++;
                    }
                }
                Console.Write(count);
                input = input.Replace(letterForCheck.ToString(), string.Empty);
            }
            return input;
        }
    }
}
