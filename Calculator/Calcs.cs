using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calcs : ICalculator
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Substraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public static int Division(int a, int b)
        {
            return a / b;
        }

        public int MultiplicationI(int a, int b)
        {
            return a * b;
        }

        public static int AddFragil(int a, int b)
        {
            int sum = a + b;
            if (sum > 10)
            {
                sum -= 2;
            }
            return sum;
        }
    }
}
