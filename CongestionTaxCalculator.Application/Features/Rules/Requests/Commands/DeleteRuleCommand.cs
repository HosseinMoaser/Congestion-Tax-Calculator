using MediatR;

namespace CongestionTaxCalculator.Application.Features.Rules.Requests.Commands;

public class DeleteRuleCommand : IRequest<Unit>
{
    public int Id { get; set; }
}
