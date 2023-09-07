using CongestionTaxCalculator.Application.DTOs.Rule;
using MediatR;

namespace CongestionTaxCalculator.Application.Features.Rules.Requests.Commands;

public class UpdateRuleCommand : IRequest<Unit>
{
    public RuleDto RuleDto { get; set; }
}
