using AutoMapper;
using CongestionTaxCalculator.Application.DTOs.Rule.Validators;
using CongestionTaxCalculator.Application.Exceptions;
using CongestionTaxCalculator.Application.Features.Rules.Requests.Commands;
using CongestionTaxCalculator.Application.Contracts.Persistence;
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
        #region Validations
        var validator = new UpdateRuleDtoValidator();
        var validationResult = await validator.ValidateAsync(request.UpdateRuleDto);

        if(!validationResult.IsValid)
        {
            throw new ValidationException(validationResult);
        }
        #endregion

        var rule = await _ruleRepository.GetById(request.UpdateRuleDto.Id);
       _mapper.Map(request.UpdateRuleDto, rule);
        await _ruleRepository.Update(rule);
        return Unit.Value;
    }
}
