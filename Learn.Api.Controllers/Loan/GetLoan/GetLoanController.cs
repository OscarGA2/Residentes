

using Learn.Api.BusinessObjects.Residents.Interface.Loan.GetLoan;
using Learn.Api.Domain.Entities.Dtos;
using Learn.Api.Domain.Entities.Dtos.Loan;

namespace Learn.Api.Controllers.Loan.GetLoan;

internal class GetLoanController(IGetLoanInputPort inputPort):IGetLoanController
{
    public async Task<ResponseDto<LoanDto>> GetAllLoanAsync()
    {
        return await inputPort.GetAllLoanAsync();
    }
}
