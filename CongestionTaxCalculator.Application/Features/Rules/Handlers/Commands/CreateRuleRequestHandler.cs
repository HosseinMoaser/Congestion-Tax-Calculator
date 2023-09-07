using AutoMapper;
using CongestionTaxCalculator.Application.DTOs.Rule.Validators;
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
        #region Validations
        var validator = new CreateRuleDtoValidator();
        var validationResult = await validator.ValidateAsync(request.CreateRuleDto);
        if (!validationResult.IsValid)
        {
            throw new Exception();
        }
        #endregion

        var rule = _mapper.Map<Rule>(request.CreateRuleDto);
        rule = await _ruleRepository.Add(rule);
        return rule.Id;
    }
}
