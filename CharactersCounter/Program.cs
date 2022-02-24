// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace Palindrome
{
	class Program
	{
        public static void Main()
        {
            Console.WriteLine("enter some string");
            string input = Console.ReadLine();
            input = input.Replace(" ", string.Empty);
           
            while(input.Length > 0)
            {
                char  letterForCheck = input[0];
                Console.Write(letterForCheck + "");
                int count = 0;
                for(int j = 0; j < input.Length; j++)
                {
                    if(letterForCheck == input[j])
                    {
                        count++;
                    }
                }
                Console.Write(count);
                input = input.Replace(letterForCheck.ToString(),string.Empty);
            }
        }
    }
}