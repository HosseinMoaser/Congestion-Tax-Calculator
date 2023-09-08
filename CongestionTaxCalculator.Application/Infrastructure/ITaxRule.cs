using CongestionTaxCalculator.Domain.Entities;

namespace CongestionTaxCalculator.Application.Infrastructure;

public interface ITaxRule
{
    Car CalculateTax(Car car, Rule rule);
}
