using FluentValidation.Results;

namespace CongestionTaxCalculator.Application.Exceptions;

public class ValidationException : ApplicationException
{
    public List<string> ErrorMessages { get; set; }

	public ValidationException(ValidationResult validationResult)
	{
		ErrorMessages = validationResult.Errors.Select(em => em.ErrorMessage).ToList();
	}
}
