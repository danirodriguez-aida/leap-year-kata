namespace leap_year_kata;

public class LeapYearCalculator
{
    public static bool IsLeapYear(int year)
    {
        if (year % 400 == 0) return true;

        return false;
    }
}