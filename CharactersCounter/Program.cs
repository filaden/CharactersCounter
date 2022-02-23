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
            var input = UserInput.EnterString();
            var operationToChose = UserInput.EnterOperation();
            var operations = new Operation();
            operations.OperationToChoose(input,operationToChose);
        }
    }
}
