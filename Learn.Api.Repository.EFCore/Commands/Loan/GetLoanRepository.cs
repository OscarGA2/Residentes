

using Learn.Api.BusinessObjects.Residents.Interface.Loan.GetLoan;
using Learn.Api.Domain.Entities.Dtos;
using Learn.Api.Domain.Entities.Dtos.Loan;
using Microsoft.Extensions.Options;

namespace Learn.Api.Repository.EFCore.Commands.Loan;

internal class GetLoanRepository(AppLoanContext context):IGetLoanRepository
{
    public Task<ResponseDto<LoanDto>> GetAllLoanAsync()
    {
        var response = new ResponseDto<LoanDto>
        {
            Items = context.Loan.Select(
            loan => new LoanDto
            (
                loan.Id,
                loan.AddLoans,
                loan.Material,
                loan.Date,
                loan.Refund,
                loan.Status)
            ).ToList()
        };
        return Task.FromResult(response);
    }

    public async Task SaveChangesAsync()
    {
       await context.SaveChangesAsync();
    }
}
