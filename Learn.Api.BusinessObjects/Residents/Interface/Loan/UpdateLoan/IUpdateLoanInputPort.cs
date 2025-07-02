
namespace Learn.Api.BusinessObjects.Residents.Interface.Loan.UpdateLoan
{
    public interface IUpdateLoanInputPort
    {
        Task UpdateLoanAsync(UpdateLoanDto loanToUpdate);
    }
}
