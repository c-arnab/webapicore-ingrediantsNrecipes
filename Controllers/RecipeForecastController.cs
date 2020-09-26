using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ingredientsNrecipesApi.Models;

namespace ingredientsNrecipesApi.Controllers
{
    [ApiController]
    [Route("/lunch")]
    public class RecipeForecastController : ControllerBase
    {
        private readonly ILogger<RecipeForecastController> _logger;

        public RecipeForecastController(ILogger<RecipeForecastController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        public List<Test> Post(List<Test> request)   //RecipeForecastRequest request
        {
            
            return request;
        }
    }
}
