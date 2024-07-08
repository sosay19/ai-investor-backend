using AIInvestmentAdvisor.Data;
using Microsoft.AspNetCore.Mvc;

namespace ai_investor_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInvestments()
        {
            var investments = DummyData.GetInvestments();
            return Ok(investments);
        }
    }
}
