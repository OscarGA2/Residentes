

using Learn.Api.BusinessObjects.Residents.Interface.Loan.RegisterLoan;
using Learn.Api.Domain.Entities.Dtos.Loan;

namespace Learn.Api.Controllers.Loan.RegisterLoan;

public class RegisterLoanController(IRegisterLoanInputPort registerLoanInputPort):IRegisterLoanController
{
    public async Task RegisterLoanAsync(RegisterLoanDto loan)
    {
        await registerLoanInputPort.RegisterLoanAsync(loan);
    }
}
