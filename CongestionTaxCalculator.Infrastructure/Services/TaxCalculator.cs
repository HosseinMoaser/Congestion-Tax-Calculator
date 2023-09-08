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

        //TODO: Find Proper Rule
        var carCurrentTime = TimeOnly.FromTimeSpan(car.CurrentRegisteredTime.TimeOfDay);
        var rule = dailyRules.FirstOrDefault(r=> carCurrentTime >= r.StartTime && carCurrentTime <= r.EndTime);

        var taxRuleEngine = new TaxRuleEngine(taxRules, rule);

        return taxRuleEngine.CalculateTax(car);

    }
}
