using Calculator;

namespace TestProjectCalculator
{
    public class CalcTest
    {
        private readonly Calc _calcs;
        
        public CalcTest()
        {
            _calcs = new Calc();
        }

        [Fact]
        public void Add_TwoNumbers_ShouldReturnSum()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 5;

            // Act
            int actual = Calcs.Sum(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        //Theory
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 5)]
        public void Add_ThreeNumbers_ShouldReturnSum(int a, int b, int expected)
        {
            //Act
            int result = Calcs.Sum(a, b);

            //Assert
            Assert.Equal(expected, result);
        }

        //errors

        [Fact]
        public void Add_FragilError_ShouldReturnCorrectAdjustedSum()
        {
            // Arrange
            int a = 7;
            int b = 5;
            int expected = 10;

            // Act
            int actual = Calcs.AddFragil(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }


    }
}
