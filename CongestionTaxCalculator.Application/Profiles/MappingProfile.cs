using AutoMapper;
using CongestionTaxCalculator.Application.DTOs.City;
using CongestionTaxCalculator.Application.DTOs.Rule;
using CongestionTaxCalculator.Domain.Entities;

namespace CongestionTaxCalculator.Application.Profiles;

public class MappingProfile : Profile
{
	public MappingProfile()
	{
		CreateMap<City,CityDto>().ReverseMap();
		CreateMap<Rule,RuleDto>().ReverseMap();
	}
}
