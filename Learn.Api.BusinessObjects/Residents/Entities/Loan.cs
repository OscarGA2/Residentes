namespace Learn.Api.BusinessObjects.Residents.Entities;

   public class Loan
    {
        public int Id { get; set; }
        public string AddLoans { get; set; }
        public string Material { get; set; }
        public DateTime Date { get; set; }
        public DateOnly Refund { get; set; }
        public string Status { get; set; }
}

