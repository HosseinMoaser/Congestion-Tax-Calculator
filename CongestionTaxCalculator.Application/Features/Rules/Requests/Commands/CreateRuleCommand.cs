﻿using CongestionTaxCalculator.Application.DTOs.Rule;
using MediatR;

namespace CongestionTaxCalculator.Application.Features.Rules.Requests.Commands;

public class CreateRuleCommand : IRequest<int>
{
    public CreateRuleDto CreateRuleDto { get; set; }
}
