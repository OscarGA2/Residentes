
namespace Learn.Api.UseCases.Loan.UpdateLoan;

public class UpdateLoanHandler(IUpdateLoanRepository repository):IUpdateLoanInputPort
{
    public async Task UpdateLoanAsync(UpdateLoanDto loanToUpdate)
    {
        bool IsUpdated = await repository.UpdateLoanAsync(loanToUpdate);
        await repository.SaveChangesAsync();
    }
}
