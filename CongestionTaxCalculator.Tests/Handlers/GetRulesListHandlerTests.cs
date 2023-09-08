using AutoMapper;
using CongestionTaxCalculator.Application.Contracts.Persistence;
using CongestionTaxCalculator.Application.DTOs.Rule;
using CongestionTaxCalculator.Application.Features.Rules.Handlers.Queries;
using CongestionTaxCalculator.Application.Features.Rules.Requests.Queries;
using CongestionTaxCalculator.Application.Profiles;
using CongestionTaxCalculator.Domain.Entities;
using CongestionTaxCalculator.Tests.Mock;
using Moq;
using Shouldly;

namespace CongestionTaxCalculator.Tests.Handlers;

public class GetRulesListHandlerTests
{
	private readonly IMapper _mapper;
	private readonly Mock<IRuleRepository> _mockRuleRepository;

    public GetRulesListHandlerTests()
	{
		_mockRuleRepository = MockRuleRepository.GetRuleRepository();
		var mapperConfig = new MapperConfiguration(m=>
		{
			m.AddProfile<MappingProfile>();
		});
		_mapper = mapperConfig.CreateMapper();
    }

	[Fact]
	public async Task  Get_Rules_List_Should_Return_A_List_Of_Rules_With_Count_Of_Ten()
	{
		//Arrange
		var handler = new GetRulesListRequestHandler(_mockRuleRepository.Object, _mapper);

		// Act
		var ruleList = await handler.Handle(new GetRulesListRequest(), CancellationToken.None);

		// Assert
		ruleList.ShouldBeOfType<List<RuleDto>>();
		ruleList.Count.ShouldBe(10);
	}
}
