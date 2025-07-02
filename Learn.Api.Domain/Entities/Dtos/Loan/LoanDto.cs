

namespace Learn.Api.Domain.Entities.Dtos.Loan;

public class LoanDto (int id, string addloans, string material, DateTime date, DateOnly refund, string status)
{
    public int Id => id;
    public string AddLoans  => addloans;
    public string Material => material;
    public DateTime Date => date;
    public DateOnly Refund => refund;
    public string Status => status;
}
