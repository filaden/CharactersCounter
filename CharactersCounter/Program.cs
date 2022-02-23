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
                Console.Write(input[0] + "");
                int count = 0;
                for(int j = 0; j < input.Length; j++)
                {
                    if(input[0] == input[j])
                    {
                        count++;
                    }
                }
                Console.Write(count);
                input = input.Replace(input[0].ToString(), string.Empty);
            }
        }
    }
}