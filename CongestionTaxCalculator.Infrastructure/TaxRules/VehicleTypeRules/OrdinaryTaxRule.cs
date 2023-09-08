using CongestionTaxCalculator.Application.Infrastructure;
using CongestionTaxCalculator.Domain.Entities;

namespace CongestionTaxCalculator.Infrastructure.TaxRules.VehicleTypeRules;

public class OrdinaryTaxRule : ITaxRule
{
    public Car CalculateTax(Car car, Rule rule)
    {
            if ((car.CurrentRegisteredTime - car.LastTaxDateTime).TotalHours < 1)
            {
                if (car.LastTax < rule.TaxValue)
                {
                    car.TotalTax += rule.TaxValue - car.LastTax;
                    car.LastTax = rule.TaxValue;
                }
                car.LastTaxDateTime = car.CurrentRegisteredTime;
                return car;
            }
            else
            {
                car.LastTax = rule.TaxValue;
                car.TotalTax += rule.TaxValue;
                car.LastTaxDateTime = car.CurrentRegisteredTime;
                return car;
            }
    }
}
