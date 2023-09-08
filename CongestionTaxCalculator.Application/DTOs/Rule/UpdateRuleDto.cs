using CongestionTaxCalculator.Application.DTOs.Common;

namespace CongestionTaxCalculator.Application.DTOs.Rule;

public class UpdateRuleDto : BaseDto
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public double TaxValue { get; set; }
    public string CityName { get; set; }
    //public string VehicleType { get; set; }
    //public int CityId { get; set; }
    //public CityDto City { get; set; }
}
