using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersCounter
{
    public class Operation
    {
        
        public static char EnterOperation()
        {
            Console.WriteLine("enter a or b for operation");
            char operationToChose = char.Parse(Console.ReadLine());
            return operationToChose;
        }
        public static void  Message()
        {
            Console.WriteLine("Invalid input entered a or b");
        }
        private IOperation _operation;
        public Operation(IOperation operation)
        {
            _operation = operation;
        }
        public void SetOperation(IOperation operation)
        {
            _operation = operation;
        }
    }
}
