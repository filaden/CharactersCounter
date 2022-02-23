using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersCounter
{
    public  class UserInput
    {
        public static string EnterString()
        {
            Console.WriteLine("Enter some string");
            string enteredString = Console.ReadLine();
            return enteredString;
        }
    }
}
