using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FizzBuzzApp.Services;

namespace FizzBuzzApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public FizzBuzzController(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        [HttpPost]
        public IActionResult FizzBuzz([FromBody] List<string> inputValues)
        {
            var results = _fizzBuzzService.ProcessFizzBuzz(inputValues);
            return Ok(results);
        }
    }
}
