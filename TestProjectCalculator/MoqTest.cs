using Calculator;
using Moq;
using Xunit;

namespace TestProjectCalculator
{
    public class MoqTest
    {
        [Fact]
        public void Add_ShouldReturnCorrectValue()
        {
            //Arrage
            int a = 2;
            int b = 3;
            int expected = 5;
            var mockCalculator = new Mock<ICalculator>();
            mockCalculator.Setup(calc => calc.Add(It.IsAny<int>(), It.IsAny<int>())).Returns(expected);

            //Act
            var result = mockCalculator.Object.Add(a, b);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Multiplication_ShouldReturnCorrectValue()
        {
            // Arrage
            int a = 2;
            int b = 2;
            int expected = 4;
            var mockCalculator = new Mock<ICalculator>();
            mockCalculator.Setup(calc => calc.MultiplicationI(It.IsAny<int>(), It.IsAny<int>())).Returns(expected);

            //Act
            var result = mockCalculator.Object.MultiplicationI(a, b);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
