using CongestionTaxCalculator.Application.Contracts.Persistence;
using CongestionTaxCalculator.Domain.Entities;

namespace CongestionTaxCalculator.Persistence.Repositories;

public class RuleRepository : GenericRepository<Rule> , IRuleRepository
{
	private readonly CongestionTaxDbContext _contex;

    public RuleRepository(CongestionTaxDbContext contex) : base(contex)
    {
        _contex = contex;
    }

}
