using CongestionTaxCalculator.Application.Infrastructure;
using CongestionTaxCalculator.Domain.Entities;

namespace CongestionTaxCalculator.Infrastructure.TaxRules.DateTimeRules;

public class JulyRule : ITaxRule
{
    public Car CalculateTax(Car car, Rule rule)
    {
        if (car.CurrentRegisteredTime.Month == 7)
        {
            car.TotalTax += 0;
            car.LastTax = 0;
            car.LastTaxDateTime = car.CurrentRegisteredTime;
            return car;
        }
        return car;
    }
}

