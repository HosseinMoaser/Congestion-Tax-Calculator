using CongestionTaxCalculator.Domain.Common;
using CongestionTaxCalculator.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CongestionTaxCalculator.Persistence;

public class CongestionTaxDbContext : DbContext
{
	public CongestionTaxDbContext(DbContextOptions<CongestionTaxDbContext> options):base(options)
	{

	}

	public DbSet<Rule> Rules { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
		modelBuilder.ApplyConfigurationsFromAssembly(typeof(CongestionTaxDbContext).Assembly);
    }

    
}
