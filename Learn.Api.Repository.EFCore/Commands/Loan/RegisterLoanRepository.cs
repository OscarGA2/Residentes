

using Learn.Api.BusinessObjects.Residents.Interface.Loan.RegisterLoan;
using Learn.Api.Domain.Entities.Dtos.Loan;

namespace Learn.Api.Repository.EFCore.Commands.Loan;

internal class RegisterLoanRepository(AppLoanContext context):IRegisterLoanRepository
{
    public Task<bool> RegisterLoanAsync(RegisterLoanDto loan)
    {
        context.Loan.Add(new BusinessObjects.Residents.Entities.Loan
        {
            AddLoans = loan.AddLoans,
            Material = loan.Material,
            Date = loan.Date,
            Refund = loan.Refund,
            Status=loan.Status,
        });
        return Task.FromResult(true);
    }

    public async Task SaveChangesAsync()
    {
        await context.SaveChangesAsync();
    }
}
