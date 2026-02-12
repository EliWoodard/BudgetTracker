namespace BudgetTracker.Data.Entities
{
    public class Transaction
    {
        public decimal Amount { get; set; }

        public int CategoryId { get; set; }

        public DateTime Date { get; set; }

        public int? FromAccountId { get; set; }

        public int Id { get; set; }

        public string? Notes { get; set; }

        public int? ToAccountId { get; set; }

        public int UserId { get; set; }
    }
}
