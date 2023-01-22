using ApprovalTests;
using ApprovalTests.Reporters;
using FluentAssertions;

namespace ConsoleApp.Tests
{
    [UseReporter(typeof(VisualStudioReporter))]
    public class CalculatorTest
    {
        [Fact]
        public void ShouldUseFluentAssertions()
        {
            int actual = 4 + 1;
            actual.Should().Be(5);
        }

        [Fact]
        public void AddTwoPositiveNumbers()
        {

            const int firstValue = 1;
            const int secondValue = 2;
            int actual = Calculator.Add(firstValue, secondValue);

            Approvals.Verify(actual);

        }

    }
}
