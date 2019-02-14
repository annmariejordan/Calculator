using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 21)]
        

        public void AddTest(int[]number, int expected)
        {
            //Arrange
            CalculatorClass calcInstance = new CalculatorClass();

            //Act
            int actual = calcInstance.Addition(number);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 5, 5)]

        public void SubtractTEST(int a, int b, int expected)
        {  //Arrange
            CalculatorClass calcInstance = new CalculatorClass();

            //Act
            int actual = calcInstance.Subtract(a, b);

            //Assert
            Assert.Equal(expected, actual);

        }
   

        [Theory]
        [InlineData(5, 5, 25)]

        public void MultiplyTEST(int a, int b, int expected)
        {  //Arrange
            CalculatorClass calcInstance = new CalculatorClass();

            //Act
            int actual = calcInstance.Multiply(a, b);

            //Assert
            Assert.Equal(expected, actual);

        }


        [Theory]
        [InlineData(25, 5, 5)]

        public void DivideTEST(double a, double b, double expected)
        {  //Arrange
            CalculatorClass calcInstance = new CalculatorClass();

            //Act
            double actual = calcInstance.Divide(a, b);

            //Assert
            Assert.Equal(expected, actual);

        }


        [Theory]
        [InlineData(5, 2, 25)]

        public void ExponentsTEST(double a, double b, double expected)
        {  //Arrange
            CalculatorClass calcInstance = new CalculatorClass();

            //Act
            double actual = calcInstance.Exponents(a, b);

            //Assert
            Assert.Equal(expected, actual);

        }


        [Theory]
        [InlineData(5, 120)]

        public void Factorial(int a, int expected)
        {
            //Arrange
            CalculatorClass calcInstance = new CalculatorClass();

            //Act
            int actual = calcInstance.Factorial(a);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
