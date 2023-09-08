﻿using CongestionTaxCalculator.Application.Infrastructure;
using CongestionTaxCalculator.Domain.Common;
using CongestionTaxCalculator.Domain.Entities;

namespace CongestionTaxCalculator.Infrastructure.TaxRules.VehicleTypeRules;

public class ForeignTaxRule : ITaxRule
{
    public Car CalculateTax(Car car, Rule rule)
    {
        if (car.VehicleType == Vehicle.Foreign)
        {
            car.TotalTax += 0;
            car.LastTax = 0;
            car.LastTaxDateTime = car.CurrentRegisteredTime;
            return car;
        }
        return car;
    }
}
