using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Calculator;

namespace UnitTestCalculator
{
    public class Example1Test
    {
        [Fact]
        public void Sum_TwoNumbers_ShouldReturnSum()
        {
            // Arrange
            Calcs
            int a = 2, b = 3;

            // Act
            var result = Calculator.Sum(a, b);

            // Assert
            Assert.Equal(5, result);
        }

    }
}
