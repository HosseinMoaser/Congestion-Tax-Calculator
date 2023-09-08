using CongestionTaxCalculator.Application.Infrastructure;
using CongestionTaxCalculator.Domain.Entities;
using CongestionTaxCalculator.Infrastructure.Exceptions;

namespace CongestionTaxCalculator.Infrastructure.TaxRules.DateTimeRules;

public class LesserYearRule : ITaxRule
{
    public Car CalculateTax(Car car, Rule rule)
    {
        if (car.CurrentRegisteredTime.Year < 2013)
        {
            throw new InvalidInputYearException("Input Year Is Less Than 2013");
        }
        return car;
    }
}
