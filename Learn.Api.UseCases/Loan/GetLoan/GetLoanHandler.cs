
namespace Learn.Api.UseCases.Loan.GetLoan;

internal class GetLoanHandler(IGetLoanRepository repository): IGetLoanInputPort
{
    public async Task<ResponseDto<LoanDto>> GetAllLoanAsync()
    {
        return await repository.GetAllLoanAsync();
    }
}
