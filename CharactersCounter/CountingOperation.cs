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
            string enteredString = input.Replace(" ", string.Empty);
           
            while (enteredString.Length > 0)
            {
                Console.Write(enteredString[0] + "");
                int count = 0;
                for(int j = 0; j < enteredString.Length; j++)
                {
                    if(enteredString[0] == enteredString[j])
                    {
                        count++;
                    }
                }
                Console.Write(count);
                enteredString = enteredString.Replace(enteredString[0].ToString(), string.Empty);
            }
            return input;
        }
    }
}
