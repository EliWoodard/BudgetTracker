namespace BudgetTracker.Data.Entities
{
    public class CashFlowProjection
    {
        public decimal Amount { get; set; }

        public int CategoryId { get; set; }

        // Inbound | Outbound
        public int FlowDirection { get; set; }

        public int Id { get; set; }

        public int RecurrenceRuleId { get; set; }

        public int? TargetAccountId { get; set; }

        public int UserId { get; set; }
    }
}
