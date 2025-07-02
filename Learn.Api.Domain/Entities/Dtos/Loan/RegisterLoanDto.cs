

namespace Learn.Api.Domain.Entities.Dtos.Loan;

public class RegisterLoanDto(string addloans, string material, DateTime date, DateOnly refund, string status)
{
    public string AddLoans => addloans;
    public string Material => material;
    public DateTime Date => date;
    public DateOnly Refund => refund;
    public string Status => status;

}
