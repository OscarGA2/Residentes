
namespace Learn.Api.BusinessObjects.Residents.Interface.Loan.RegisterLoan;

public interface IRegisterLoanInputPort
{
    Task RegisterLoanAsync(RegisterLoanDto loan);
}
