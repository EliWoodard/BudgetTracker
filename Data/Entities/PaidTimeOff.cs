namespace BudgetTracker.Data.Entities
{
    public class PaidTimeOff
    {
        public decimal AccrualRate { get; set; }

        public int Amount { get; set; }

        public string BankName { get; set; }

        public int Id { get; set; }

        public int UserId { get; set; }
    }
}
