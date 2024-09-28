using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstRESTProject.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/MyFirstAPI")]
    [ApiController]
    public class MyFirstAPIController : ControllerBase
    {
        [HttpGet("MyName",Name ="MyName")]
        public string GetMyName()
        {
            return "My Name Is Karim";
        }

        [HttpGet("YourName", Name = "YourName")]
        public string GetYourName()
        {
            return "Your Name Is Maher";
        }

        [HttpGet("Sum/{Num1}/{Num2}")]
        public int Sum2Numbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
        [HttpGet("Multi/{Num1}/{Num2}")]
        public int Multi2Numbers(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
    }
}
