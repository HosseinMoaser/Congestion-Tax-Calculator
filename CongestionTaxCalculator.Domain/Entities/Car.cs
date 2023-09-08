using CongestionTaxCalculator.Domain.Common;

namespace CongestionTaxCalculator.Domain.Entities;

public class Car
{
    public Vehicle VehicleType { get; set; }
    public double LastTax { get; set; }
    public DateTime LastTaxDateTime { get; set; }
    public double TotalTax { get; set; }
    public DateTime CurrentRegisteredTime { get; set; }

}
