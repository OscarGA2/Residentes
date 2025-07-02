
using Learn.Api.BusinessObjects.Residents.Interface.Loan.UpdateLoan;
using Learn.Api.Domain.Entities.Dtos.Loan;

namespace Learn.Api.Controllers.Loan.UpdateLoan;

internal class UpdateLoanController(IUpdateLoanInputPort inputPort): IUpdateLoanController
{
    public async ValueTask UpdateLoanAsync(UpdateLoanDto loanToUpdate)
    {
        await inputPort.UpdateLoanAsync(loanToUpdate);
    }
}
