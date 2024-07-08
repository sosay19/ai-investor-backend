// /Data/DummyData.cs
using System.Collections.Generic;
using ai_investor_backend.Models;
using ai_investor_backend.Models.AIInvestmentAdvisor.Models;

namespace AIInvestmentAdvisor.Data
{
    public static class DummyData
    {
        public static List<Investment> GetInvestments()
        {
            return new List<Investment>
            {
                new Investment
                {
                    Id = 1,
                    Type = "Bond",
                    Risk = "Low",
                    PotentialReturn = "5%",
                    Action = "Buy",
                    Details = "Long-term government bond",
                    History = "2% annual growth",
                    Feedback = "Stable investment"
                },
                new Investment
                {
                    Id = 2,
                    Type = "Stock",
                    Risk = "Medium",
                    PotentialReturn = "10%",
                    Action = "Hold",
                    Details = "Technology sector stock",
                    History = "15% annual growth",
                    Feedback = "Potential for high returns"
                },
                new Investment
                {
                    Id = 3,
                    Type = "ETF",
                    Risk = "High",
                    PotentialReturn = "15%",
                    Action = "Sell",
                    Details = "Broad market index ETF",
                    History = "12% annual growth",
                    Feedback = "Diversified and high-risk"
                }
            };
        }
    }
}
