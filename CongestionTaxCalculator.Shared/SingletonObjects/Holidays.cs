namespace CongestionTaxCalculator.Shared.SingletonObjects;

public class Holidays
{
    private static Holidays? holidays;
    public List<DateTime> HolidayList { get; private set; }

    public static Holidays GetInstance()
    {
        if (holidays is null)
        {
            holidays = new Holidays(new List<DateTime>
            {
                new DateTime(2013, 1, 1),  // New Year's Day
                new DateTime(2013, 1, 6),  // Epiphany
                new DateTime(2013, 3, 29), // Good Friday
                new DateTime(2013, 4, 1), // Easter Monday
                new DateTime(2013, 5, 1),  // International Workers' Day
                new DateTime(2013, 5, 9), // Ascension Day
                new DateTime(2013, 6, 6), // National Day of Sweden
                new DateTime(2013, 6, 21), // Midsummer Eve
                new DateTime(2013, 6, 22), // Midsummer Day
                new DateTime(2013, 11, 2), // All Saints' Day
                new DateTime(2013, 12, 24), // Christmas Eve
                new DateTime(2013, 12, 25), // Christmas Day
                new DateTime(2013, 12, 26) // Boxing Day
			});
        }

        return holidays;
    }

    private Holidays(List<DateTime> holidays)
    {
        HolidayList = holidays;
    }
}
