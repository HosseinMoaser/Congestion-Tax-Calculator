﻿using CongestionTaxCalculator.Domain.Common;

namespace CongestionTaxCalculator.Domain.Entities;

public class Rule : BaseEntity
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public double TaxValue { get; set; }
    public string CityName { get; set; }
    //public string VehicleType { get; set; }
    //public int CityId { get; set; }
    //public City City { get; set; }
}
