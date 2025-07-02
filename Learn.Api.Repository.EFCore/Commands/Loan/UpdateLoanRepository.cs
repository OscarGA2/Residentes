
using Learn.Api.BusinessObjects.Residents.Interface.Loan.UpdateLoan;
using Learn.Api.Domain.Entities.Dtos.Loan;

namespace Learn.Api.Repository.EFCore.Commands.Loan;

internal class UpdateLoanRepository(AppLoanContext context):IUpdateLoanRepository
{

public Task<bool> UpdateLoanAsync(UpdateLoanDto loanToUpdate)
    {
        var LoanToUpdate = context.Loan.Find(loanToUpdate.Id);
        if (loanToUpdate != null)
        {
            LoanToUpdate.Id= loanToUpdate.Id;
            //LoanToUpdate.AddLoans = loanToUpdate.AddLoans;
            //LoanToUpdate.Material = loanToUpdate.Material;
            //LoanToUpdate.Date = loanToUpdate.Date;
            //LoanToUpdate.Refund = loanToUpdate.Refund;
            LoanToUpdate.Status = loanToUpdate.Status;
        }
        return Task.FromResult(true);
    }

    public async Task SaveChangesAsync()
    {
        await context.SaveChangesAsync();
    }
}
