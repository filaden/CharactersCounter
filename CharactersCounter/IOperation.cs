using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersCounter
{
    public interface IOperation
    {
        char operationType { get; }
        string ChooseOperation(string input);
    }
}
