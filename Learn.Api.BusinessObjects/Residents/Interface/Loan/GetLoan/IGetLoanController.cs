

namespace Learn.Api.BusinessObjects.Residents.Interface.Loan.GetLoan;

public interface IGetLoanController
{
    Task<ResponseDto<LoanDto>> GetAllLoanAsync(); 
}
