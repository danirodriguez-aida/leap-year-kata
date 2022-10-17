using FluentAssertions;
using leap_year_kata;

namespace leap_year_tests {
    public class LeapYearCalculatorShould {
        [SetUp]
        public void Setup() {
        }

        [TestCase (400, TestName = "for 400")]
        [TestCase (400, TestName = "for 800")]
        public void return_leap_year_when_divisible_by_400(int year)
        {
            var result = LeapYearCalculator.IsLeapYear(year);

            result.Should().BeTrue();
        }

        [Test]
        public void return_not_leap_year_when_divisible_by_100_but_not_400()
        {
            var result = LeapYearCalculator.IsLeapYear(100);

            result.Should().BeFalse();
        }

        [Test]
        public void return_leap_year_when_divisible_by_4_but_not_100()
        {
            var result = LeapYearCalculator.IsLeapYear(4);

            result.Should().BeTrue();
        }
    }
}