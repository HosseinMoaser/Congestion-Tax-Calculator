using CongestionTaxCalculator.Application.Infrastructure;
using CongestionTaxCalculator.Domain.Entities;

namespace CongestionTaxCalculator.Infrastructure.TaxRules.DateTimeRules;

public class SundayRule : ITaxRule
{
    public Car CalculateTax(Car car, Rule rule)
    {
        if (car.CurrentRegisteredTime.DayOfWeek == DayOfWeek.Sunday)
        {
            car.TotalTax += 0;
            car.LastTax = 0;
            car.LastTaxDateTime = car.CurrentRegisteredTime;
            return car;
        }
        return car;
    }
}

