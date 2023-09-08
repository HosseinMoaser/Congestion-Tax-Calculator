using AutoMapper;
using CongestionTaxCalculator.Application.DTOs.Rule;
using CongestionTaxCalculator.Application.Features.Rules.Requests.Queries;
using CongestionTaxCalculator.Application.Contracts.Persistence;
using MediatR;

namespace CongestionTaxCalculator.Application.Features.Rules.Handlers.Queries;

public class GetRulesListRequestHandler : IRequestHandler<GetRulesListRequest, List<RuleDto>>
{
    private readonly IRuleRepository _ruleRepository;
    private readonly IMapper _mapper;

    public GetRulesListRequestHandler(IRuleRepository ruleRepository, IMapper mapper)
    {
        _ruleRepository = ruleRepository;
        _mapper = mapper;
    }

    public async Task<List<RuleDto>> Handle(GetRulesListRequest request, CancellationToken cancellationToken)
    {
        var rulesList = await _ruleRepository.GetAll();
        return _mapper.Map<List<RuleDto>>(rulesList);
    }
}
