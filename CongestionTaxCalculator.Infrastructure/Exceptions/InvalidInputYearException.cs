namespace CongestionTaxCalculator.Infrastructure.Exceptions;

public class InvalidInputYearException : ApplicationException
{
    public InvalidInputYearException(string message) : base(message)
    {

    }
}
