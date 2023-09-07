using CongestionTaxCalculator.Application.DTOs.Rule;
using MediatR;

namespace CongestionTaxCalculator.Application.Features.Rules.Requests.Queries;

public class GetRulesListRequest : IRequest<List<RuleDto>>
{
}
