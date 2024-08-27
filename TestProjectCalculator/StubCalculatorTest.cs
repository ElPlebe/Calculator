using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectCalculator
{
    public class StubCalculatorTest
    {
        [Fact]
        public void Add_WithStub_ShouldReturnFixValue()
        {
            //Arrage
            int a = 2;
            int b = 3;
            int expected = 10;
            ICalculator calculator = new CalculatorStub();

            //Act
            int result = calculator.Add(a, b);

            //Assert
            Assert.Equal(expected,result);
        }

        [Fact]
        public void Multiplicator_WithStub_ShouldReturnFixValue()
        {
            //Arrage
            int a = 2;
            int b = 3;
            int expected = 20;
            ICalculator calculator = new CalculatorStub();

            //Act
            int result = calculator.MultiplicationI(a, b);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
