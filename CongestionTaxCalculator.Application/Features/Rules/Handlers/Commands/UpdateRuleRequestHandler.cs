using AutoMapper;
using CongestionTaxCalculator.Application.Features.Rules.Requests.Commands;
using CongestionTaxCalculator.Application.Persistence.Contracts;
using CongestionTaxCalculator.Domain.Entities;
using MediatR;

namespace CongestionTaxCalculator.Application.Features.Rules.Handlers.Commands;

public class UpdateRuleRequestHandler : IRequestHandler<UpdateRuleCommand, Unit>
{
    private readonly IRuleRepository _ruleRepository;
    private readonly IMapper _mapper;

    public UpdateRuleRequestHandler(IRuleRepository ruleRepository, IMapper mapper)
    {
        _ruleRepository = ruleRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateRuleCommand request, CancellationToken cancellationToken)
    {
        var rule = await _ruleRepository.GetById(request.RuleDto.Id);
       _mapper.Map(request.RuleDto, rule);
        rule = await _ruleRepository.Update(rule);
        return Unit.Value;
    }
}
