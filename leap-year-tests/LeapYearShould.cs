using FluentAssertions;
using leap_year_kata;

namespace leap_year_tests {
    public class LeapYearCalculatorShould {
        [SetUp]
        public void Setup() {
        }

        [TestCase (400, TestName = "for 400")]
        [TestCase (800, TestName = "for 800")]
        [TestCase (2000, TestName = "for 1600")]
        [TestCase (2000, TestName = "for 2000")]
        public void return_leap_year_when_divisible_by_400(int year)
        {
            var result = LeapYearCalculator.IsLeapYear(year);

            result.Should().BeTrue();
        }

        [TestCase (100, TestName = "for 100")]
        [TestCase (300, TestName = "for 300")]
        [TestCase (1800, TestName = "for 1800")]
        [TestCase (1900, TestName = "for 1900")]
        public void return_not_leap_year_when_divisible_by_100_but_not_400(int year)
        {
            var result = LeapYearCalculator.IsLeapYear(year);

            result.Should().BeFalse();
        }

        [TestCase (4, TestName = "for 4")]
        [TestCase (1064, TestName = "for 1064")]
        [TestCase (2016, TestName = "for 2016")]
        [TestCase (2020, TestName = "for 20201064")]
        public void return_leap_year_when_divisible_by_4_but_not_100(int year)
        {
            var result = LeapYearCalculator.IsLeapYear(year);

            result.Should().BeTrue();
        }

        [TestCase (3, TestName = "for 3")]
        [TestCase (566, TestName = "for 563")]
        [TestCase (1019, TestName = "for 2019")]
        [TestCase (2021, TestName = "for 2021")]
        public void return_not_leap_year_when_not_divisible_by_4(int year)
        {
            var result = LeapYearCalculator.IsLeapYear(year);

            result.Should().BeFalse();
        }
    }
}