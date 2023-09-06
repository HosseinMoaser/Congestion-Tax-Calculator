using CongestionTaxCalculator.Domain.Common;

namespace CongestionTaxCalculator.Domain.Entities;

public class City : BaseEntity
{
    public string CityName { get; set; }
    public List<Rule> Rules { get; set; }
}
