namespace BudgetTracker.Data.Entities
{
    public  class RecurrenceRule
    {
        public int? DayOfMonth { get; set; }

        public int? DayOfWeek { get; set; }

        public DateTime? EndDate { get; set; }

        // daily, weekly, monthly, or yearly
        public int FrequencyId { get; set; }

        public int Id { get; set; }

        // # days, # weeks, # months
        public int Interval { get; set; }

        public DateTime StartDate { get; set; }
    }
}
