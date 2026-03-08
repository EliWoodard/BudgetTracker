namespace BudgetTracker.Data.Entities
{
    public class Account
    {
        public int AccountTypeId { get; set; }

        public decimal? AnnualPercentageRate { get; set; }

        public decimal? AnnualPercentageYield { get; set; }

        public decimal Balance { get; set; }

        public int Id { get; set; }

        public DateTime OpenDate { get; set; }

        public int UserId { get; set; }
    }
}
