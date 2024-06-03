using Calculadora.Models;
using Xunit;

namespace Calculadora.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(6,2,8)]
        [InlineData(2,2,4)]
        public void TestAddition(int val1, int val2, int res)
        {
            var calc = new Calculator();
            int result = calc.getSum(val1, val2);
            Assert.Equal(res, result);
        }

        [Fact]
        public void TestSubtraction()
        {
            var calc = new Calculator();
            int result = calc.getSubtraction(10, 4);
            Assert.Equal(6, result);
        }

        [Fact]
        public void TestMultiplication()
        {
            var calc = new Calculator();
            int result = calc.getMultiplication(3, 4);
            Assert.Equal(12, result);
        }

        [Fact]
        public void TestDivision()
        {
            var calc = new Calculator();
            int result = calc.getDivision(12, 4);
            Assert.Equal(3, result);
        }

        [Fact]
        public void TestDivisionByZero()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.getDivision(3, 0));
        }

        [Fact]
        public void TestOperationsHistoric()
        {
            var calc = new Calculator();
            calc.getSum(1, 2);
            calc.getSubtraction(5, 3);
            calc.getMultiplication(2, 3);
            calc.getDivision(10, 2);

            calc.OperationsHistoric();

            // Expecting the HistoricList to only contain the last 3 operations
            Assert.Equal(3, calc.HistoricList.Count);
            Assert.Contains("Result: 2", calc.HistoricList);
            Assert.Contains("Result: 6", calc.HistoricList);
            Assert.Contains("Result: 5", calc.HistoricList);
        }
    }
}
