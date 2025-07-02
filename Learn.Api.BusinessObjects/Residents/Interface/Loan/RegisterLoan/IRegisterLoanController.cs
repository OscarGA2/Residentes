

namespace Learn.Api.BusinessObjects.Residents.Interface.Loan.RegisterLoan;

public interface IRegisterLoanController
{
    Task RegisterLoanAsync(RegisterLoanDto inputModel);
}
