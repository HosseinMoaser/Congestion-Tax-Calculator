using CongestionTaxCalculator.Application.Infrastructure;
using CongestionTaxCalculator.Domain.Entities;
using CongestionTaxCalculator.Infrastructure.Infrastructure;
using System;

namespace CongestionTaxCalculator.Infrastructure.Services;

public class TaxCalculator
{
    public Car CalcCarTax(Car car, List<Rule> dailyRules)
    {
        var ruleType = typeof(ITaxRule);
        IEnumerable<ITaxRule> taxRules = this.GetType().Assembly
            .GetTypes()
            .Where(r=> ruleType.IsAssignableFrom(r) && !r.IsInterface)
            .Select(r=> Activator.CreateInstance(r) as ITaxRule);

        // Find Proper Rule
        var carCurrentTime = car.CurrentRegisteredTime.TimeOfDay;
        var rule = dailyRules.FirstOrDefault(r=> carCurrentTime >= r.StartTime.TimeOfDay && carCurrentTime <= r.EndTime.TimeOfDay);

        var taxRuleEngine = new TaxRuleEngine(taxRules, rule);

        return taxRuleEngine.CalculateTax(car);

    }
}
