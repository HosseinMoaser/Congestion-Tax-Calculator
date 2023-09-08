using CongestionTaxCalculator.Application.Infrastructure;
using CongestionTaxCalculator.Domain.Entities;

namespace CongestionTaxCalculator.Infrastructure.Infrastructure;

public class TaxRuleEngine
{
    private readonly List<ITaxRule> _taxRules= new List<ITaxRule>();
    private readonly Rule _currentRule;
    public TaxRuleEngine(IEnumerable<ITaxRule> taxRules, Rule currentRule)
    {
        _taxRules.AddRange(taxRules);
        _currentRule = currentRule;
    }

    public Car CalculateTax(Car car)
    {
        foreach(var taxRule in _taxRules)
        {
            car = taxRule.CalculateTax(car,_currentRule);
        }

        return car;
    }

}
