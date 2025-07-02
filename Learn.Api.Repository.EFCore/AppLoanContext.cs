
using Learn.Api.BusinessObjects.Residents.Entities;
using Microsoft.EntityFrameworkCore;

namespace Learn.Api.Repository.EFCore;

public class AppLoanContext(DbContextOptions<AppLoanContext> options): DbContext(options)
{
    public DbSet<Loan> Loan { get; set; }
}
