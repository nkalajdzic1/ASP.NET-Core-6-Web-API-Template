using Core.Interfaces;
using Web.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomController : ControllerBase
    {
        private readonly ILogger<RandomController> _logger;
        private readonly IRandomService _randomService;

        public RandomController(IRandomService randomService, ILogger<RandomController> logger)
        {
            _randomService = randomService;
            _logger = logger;
        }

        [HttpGet]
        public string Get() => _randomService.GetRandom();

        [HttpGet("{Id}")]
        public string GetById([FromRoute] GetRandomByIdRequest getRandomById) => _randomService.GetRandomById(getRandomById.Id);
        
    }
}