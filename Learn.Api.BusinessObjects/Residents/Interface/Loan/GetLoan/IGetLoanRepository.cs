

namespace Learn.Api.BusinessObjects.Residents.Interface.Loan.GetLoan;

public interface IGetLoanRepository
{
    Task<ResponseDto<LoanDto>> GetAllLoanAsync();
    Task SaveChangesAsync();
}
