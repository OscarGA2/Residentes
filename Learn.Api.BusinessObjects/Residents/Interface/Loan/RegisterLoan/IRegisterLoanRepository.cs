

namespace Learn.Api.BusinessObjects.Residents.Interface.Loan.RegisterLoan;

public interface IRegisterLoanRepository
{
    Task<bool> RegisterLoanAsync(RegisterLoanDto loan);
    Task SaveChangesAsync();
}
