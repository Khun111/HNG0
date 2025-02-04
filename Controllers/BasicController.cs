using Microsoft.AspNetCore.Mvc;
using static Services.MathUtil;

namespace Controllers
{
    [Route("api/classify-number")]
    [ApiController]
    public class BasicController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetNumberFacts([FromQuery] string number)
        {
            // Initialize HttpClient
            HttpClient client = new HttpClient();

            // Validate if the input is a valid integer
            if (!int.TryParse(number, out int num))
            {
                return BadRequest(new { number = "alphabet", error = "true" });
            }

            // Fetch fun fact about the number
            var response = client.GetAsync($"http://numbersapi.com/{number}/math").Result;
            if (!response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode, "Error fetching fun fact");
            }

            // Determine properties of the number
            List<string> properties = new List<string>();
            if (IsArmstrong(num))
            {
                properties.Add("armstrong");
            }
            if (IsEven(num))
            {
                properties.Add("even");
            }
            else
            {
                properties.Add("odd");
            }

            // Return the result as a JSON object
            return Ok(new
            {
                number = num,
                is_prime = IsPrime(num),
                is_even = IsEven(num),
                is_perfect = IsPerfect(num),
                properties,
                digit_sum = DigitSum(num),
                fun_fact = response.Content.ReadAsStringAsync().Result
            });
        }
    }
}