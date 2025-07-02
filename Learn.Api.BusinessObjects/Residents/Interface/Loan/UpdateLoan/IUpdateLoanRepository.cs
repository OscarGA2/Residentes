

namespace Learn.Api.BusinessObjects.Residents.Interface.Loan.UpdateLoan;

public interface IUpdateLoanRepository
{
    Task <bool> UpdateLoanAsync(UpdateLoanDto loanToUpdate);
    Task SaveChangesAsync();
}
