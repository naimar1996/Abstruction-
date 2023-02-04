using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp63
{
    public sealed class Multiplication : Calculation
    {
        public override int Operate(int number1, int number2)
        {
            int multip = number1 * number2;
            return multip;
        }
    }
}
