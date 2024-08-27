using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorStub : ICalculator
    {
        public int Add(int a, int b)
        {
            return 10; //Always return 10
        }

        public int MultiplicationI(int a, int b)
        {
            return 20;
        }
    }
}
