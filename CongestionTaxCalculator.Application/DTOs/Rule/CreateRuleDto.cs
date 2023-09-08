namespace CongestionTaxCalculator.Application.DTOs.Rule;

public class CreateRuleDto
{
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public double TaxValue { get; set; }
    public string CityName { get; set; }
    //public string VehicleType { get; set; }
    //public int CityId { get; set; }
    //public CityDto City { get; set; }
}
