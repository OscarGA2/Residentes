

namespace Learn.Api.BusinessObjects.Residents.Interface.Loan.UpdateLoan;

public interface IUpdateLoanController
{
    ValueTask UpdateLoanAsync(UpdateLoanDto loanToUpdate);
}
