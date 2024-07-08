using ai_investor_backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace ai_investor_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvestmentController : ControllerBase
    {
        private readonly PythonModelIntegration _pythonModelIntegration;

        public InvestmentController(PythonModelIntegration pythonModelIntegration)
        {
            _pythonModelIntegration = pythonModelIntegration;
        }

        [HttpPost("predict")]
        public async Task<IActionResult> Predict([FromBody] float[] features)
        {
            var prediction = await _pythonModelIntegration.GetPredictionAsync(features);
            return Ok(new { Prediction = prediction });
        }
    }
}
