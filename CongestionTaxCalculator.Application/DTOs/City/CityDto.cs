using CongestionTaxCalculator.Application.DTOs.Common;
using CongestionTaxCalculator.Application.DTOs.Rule;

namespace CongestionTaxCalculator.Application.DTOs.City;

public class CityDto : BaseDto
{
    public string CityName { get; set; }
    public List<RuleDto> Rules { get; set; }
}
