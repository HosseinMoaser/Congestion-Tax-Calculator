using FluentValidation;

namespace CongestionTaxCalculator.Application.DTOs.Rule.Validators;

public class CreateRuleDtoValidator : AbstractValidator<CreateRuleDto>
{
	public CreateRuleDtoValidator()
	{
		RuleFor(p=> p.StartTime).NotEmpty()
			.WithMessage("{PropertyName} could not be empty...!")
			.NotNull()
			.LessThan(p=> p.EndTime);

		RuleFor(p => p.EndTime).NotEmpty()
			.WithMessage("{PropertyName} could not be empty...!")
			.NotNull()
			.GreaterThan(p=> p.StartTime);

		RuleFor(p => p.TaxValue).NotEmpty()
			.WithMessage("{PropertyName} could not be empty...!")
			.LessThan(0)
			.WithMessage("{PropertyName} could not be less than 0 ...!");

		//RuleFor(p => p.VehicleType).NotEmpty()
		//	.WithMessage("{PropertyName} could not be empty...!")
		//	.NotNull();

		RuleFor(p => p.CityName).NotEmpty()
			.WithMessage("{PropertyName} could not be empty...!")
			.NotNull();

	}
}
