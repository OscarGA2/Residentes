

namespace Learn.Api.BusinessObjects.Residents.Interface.Loan.GetLoan;

public interface IGetLoanInputPort
{
    Task <ResponseDto<LoanDto>> GetAllLoanAsync();
}
