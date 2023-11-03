using Microsoft.AspNetCore.Mvc;
using _01.Models;

namespace _01.Controllers
{
    public class APIController : ControllerBase
    {
        public APIController(Numbers Numccal)
        {
            this.Numccal = Numccal;
        }
        public IActionResult Index()
        {
            return Ok("Correct.");
        }
        
    
    }
}
