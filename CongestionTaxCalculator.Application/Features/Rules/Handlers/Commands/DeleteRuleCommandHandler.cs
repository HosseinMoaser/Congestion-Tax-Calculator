using AutoMapper;
using CongestionTaxCalculator.Application.Exceptions;
using CongestionTaxCalculator.Application.Features.Rules.Requests.Commands;
using CongestionTaxCalculator.Application.Persistence.Contracts;
using MediatR;

namespace CongestionTaxCalculator.Application.Features.Rules.Handlers.Commands;

public class DeleteRuleCommandHandler : IRequestHandler<DeleteRuleCommand,Unit>
{
    private readonly IRuleRepository _ruleRepository;

    public DeleteRuleCommandHandler(IRuleRepository ruleRepository)
    {
        _ruleRepository = ruleRepository;
    }

    public async Task<Unit> Handle(DeleteRuleCommand request, CancellationToken cancellationToken)
    {
        var rule = await _ruleRepository.GetById(request.Id);
        if(rule == null)
        {
            throw new NotFoundException(nameof(rule), request.Id);
        }
        await _ruleRepository.Delete(rule);
        return Unit.Value;
    }
}
