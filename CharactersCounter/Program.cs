// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Linq;
namespace CharactersCounter
{
	class Program
	{
        public static void Main()
        {
            Console.WriteLine("Enter some string");
            string enteredString = Console.ReadLine();
            char[] enteredCharString = enteredString.ToCharArray();

            Console.WriteLine("enter a or b for operation");

            char operationToChose = char.Parse(Console.ReadLine());
            
            if (operationToChose.Equals('a'))
            {
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
            }
            else if (operationToChose.Equals('b'))
            {
                string result = string.Empty;

                for (int i = 0; i < enteredString.Length; i++)
                {
                    if (!result.Contains(enteredString[i]))
                    {
                        result = result + enteredCharString[i];
                    }

                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input entered a or b");
            }
        }
    }
}
