using AutoMapper;
using CongestionTaxCalculator.Application.Features.Rules.Requests.Commands;
using CongestionTaxCalculator.Application.Persistence.Contracts;
using CongestionTaxCalculator.Domain.Entities;
using MediatR;

namespace CongestionTaxCalculator.Application.Features.Rules.Handlers.Commands;

public class CreateRuleRequestHandler : IRequestHandler<CreateRuleCommand, int>
{
    private readonly IRuleRepository _ruleRepository;
    private readonly IMapper _mapper;

    public CreateRuleRequestHandler(IRuleRepository ruleRepository, IMapper mapper)
    {
        _ruleRepository = ruleRepository;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateRuleCommand request, CancellationToken cancellationToken)
    {
        var rule = _mapper.Map<Rule>(request.RuleDto);
        rule =await _ruleRepository.Add(rule);
        return rule.Id;
    }
}
