using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;

namespace ai_investor_backend.Services
{
    public class PythonModelIntegration
    {
        private readonly HttpClient _httpClient;

        public PythonModelIntegration(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<float> GetPredictionAsync(float[] features)
        {
            var requestData = features.ToList();
            var requestContent = new StringContent(JsonSerializer.Serialize(requestData), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("/predict", requestContent);
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Response from API: {responseString}");  // Log the response

            // Ensure deserialization matches the exact JSON structure
            var predictionResult = JsonSerializer.Deserialize<PredictionResult>(responseString, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return predictionResult.Prediction;
        }

    }


    public class PredictionResult
    {
        public float Prediction { get; set; }
    }
}
