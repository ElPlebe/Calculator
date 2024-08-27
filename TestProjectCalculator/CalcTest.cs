using Calculator;

namespace TestProjectCalculator
{
    public class CalcTest
    {
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
