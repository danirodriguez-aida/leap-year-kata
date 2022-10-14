using FluentAssertions;

namespace leap_year_tests {
    public class LeapYearCalculatorShould {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void return_leap_year_when_year_divisible_by_400()
        {
            var result = LeapYearCalculator.IsLeapYear(400);

            result.Should().BeTrue();
        }
    }

    public class LeapYearCalculator
    {
        public static bool IsLeapYear(int year)
        {
            throw new NotImplementedException();
        }
    }
}