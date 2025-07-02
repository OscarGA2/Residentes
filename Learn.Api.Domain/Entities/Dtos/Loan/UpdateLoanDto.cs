

namespace Learn.Api.Domain.Entities.Dtos.Loan;
/*
public class UpdateLoanDto(int id, string addloans, string material, DateTime date, DateOnly refund, string status)
{
    public int Id => id;
    public string AddLoans => addloans;
    public string Material => material;
    public DateTime Date => date;
    public DateOnly Refund => refund;
    public string Status => status;
}
*/
public class UpdateLoanDto(int id, string status)
{
    public int Id => id;
    public string Status => status;
}