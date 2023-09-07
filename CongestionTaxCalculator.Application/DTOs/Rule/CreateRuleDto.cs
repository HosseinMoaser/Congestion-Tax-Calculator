﻿namespace CongestionTaxCalculator.Application.DTOs.Rule;

public class CreateRuleDto
{
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }
    public string VehicleType { get; set; }
    public double TaxValue { get; set; }
    public string CityName { get; set; }
    //public int CityId { get; set; }
    //public CityDto City { get; set; }
}
