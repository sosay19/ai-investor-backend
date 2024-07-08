namespace ai_investor_backend.Models
{
    // /Models/Investment.cs
    namespace AIInvestmentAdvisor.Models
    {
        public class Investment
        {
            public int Id { get; set; }
            public string Type { get; set; }
            public string Risk { get; set; }
            public string PotentialReturn { get; set; }
            public string Action { get; set; }
            public string Details { get; set; }
            public string History { get; set; }
            public string Feedback { get; set; }
        }
    }
}
