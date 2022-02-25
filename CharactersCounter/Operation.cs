using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersCounter
{
    public class Operation
    {
        public  string OperationToChoose (string input, string operationToChose)
        {
            IFilterOperation filter = new FilteringOperation();
            ICountingOperation counting = new CountingOperation();

            if (operationToChose == "a")
            {
                return counting.Counting(input);
            }
            else if (operationToChose == "b")
            {
                return filter.Filter(input);
            }
            else
            {
                return "Invalid input entered a or b";
            }
        }
    }
}
