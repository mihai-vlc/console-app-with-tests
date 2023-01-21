using ConsoleWithTests;
using FluentAssertions;

namespace XunitTest
{
    public class CalculatorTest
    {
        [Fact]
        public void Test1()
        {
            Assert.StrictEqual(1, 1);
        }

        [Fact]
        public void AddTwoPositiveNumbers()
        {


            const int firstValue = 1;
            const int secondValue = 2;
            int actual = Calculator.Add(firstValue, secondValue);

            actual.Should().BeLessThan(10);

        }

    }
}
