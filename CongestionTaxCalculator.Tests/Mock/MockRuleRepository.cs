﻿using CongestionTaxCalculator.Application.Contracts.Persistence;
using CongestionTaxCalculator.Domain.Entities;
using Moq;

namespace CongestionTaxCalculator.Tests.Mock;

public static class MockRuleRepository
{
    public static Mock<IRuleRepository> GetRuleRepository()
    {
        var ruleList = new List<Rule>()
        {
             new Rule {Id = 1, CityName = "Gothenburg", StartTime = new DateTime(1, 1, 1, 6, 0, 0), EndTime = new DateTime(1, 1, 1, 6, 29, 0), TaxValue = 8 },
            new Rule {Id = 2, CityName = "Gothenburg", StartTime = new DateTime(1, 1, 1, 6, 30, 0), EndTime = new DateTime(1, 1, 1, 6, 59, 0), TaxValue = 13 },
            new Rule {Id = 3, CityName = "Gothenburg", StartTime = new DateTime(1, 1, 1, 7, 0, 0), EndTime = new DateTime(1, 1, 1, 7, 59, 0), TaxValue = 18 },
            new Rule {Id = 4, CityName = "Gothenburg", StartTime = new DateTime(1, 1, 1, 8, 0, 0), EndTime = new DateTime(1, 1, 1, 8, 29, 0), TaxValue = 13 },
            new Rule {Id = 5, CityName = "Gothenburg", StartTime = new DateTime(1, 1, 1, 8, 30, 0), EndTime = new DateTime(1, 1, 1, 14, 59, 0), TaxValue = 8 },
            new Rule {Id = 6, CityName = "Gothenburg", StartTime = new DateTime(1, 1, 1, 15, 0, 0), EndTime = new DateTime(1, 1, 1, 15, 29, 0), TaxValue = 13 },
            new Rule {Id = 7, CityName = "Gothenburg", StartTime = new DateTime(1, 1, 1, 15, 30, 0), EndTime = new DateTime(1, 1, 1, 16, 59, 0), TaxValue = 18 },
            new Rule {Id = 8, CityName = "Gothenburg", StartTime = new DateTime(1, 1, 1, 17, 0, 0), EndTime = new DateTime(1, 1, 1, 17, 59, 0), TaxValue = 13 },
            new Rule {Id = 9, CityName = "Gothenburg", StartTime = new DateTime(1, 1, 1, 18, 0, 0), EndTime = new DateTime(1, 1, 1, 18, 29, 0), TaxValue = 8 },
            new Rule {Id = 10, CityName = "Gothenburg", StartTime = new DateTime(1, 1, 1, 18, 30, 0), EndTime = new DateTime(1, 1, 1, 5, 59, 0), TaxValue = 0 }
        };
        var mockRepository = new Mock<IRuleRepository>();

        mockRepository.Setup(r => r.GetAll()).ReturnsAsync(ruleList);

        mockRepository.Setup(r => r.Add(It.IsAny<Rule>()))
            .ReturnsAsync((Rule rule) =>
            {
                ruleList.Add(rule);
                return rule;
            });

        return mockRepository;
    }
}
