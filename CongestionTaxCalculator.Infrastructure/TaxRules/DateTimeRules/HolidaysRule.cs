using CongestionTaxCalculator.Application.Infrastructure;
using CongestionTaxCalculator.Domain.Entities;
using CongestionTaxCalculator.Shared.SingletonObjects;

namespace CongestionTaxCalculator.Infrastructure.TaxRules.DateTimeRules;

public class HolidaysRule : ITaxRule
{
    public Car CalculateTax(Car car, Rule rule)
    {
        var holidays = Holidays.GetInstance().HolidayList;
        if(holidays.Any(holiday => holiday.Date == car.CurrentRegisteredTime.Date))
        {
            car.TotalTax += 0;
            car.LastTax = 0;
            car.LastTaxDateTime = car.CurrentRegisteredTime;
            return car;
        }

        return car;
    }
}
