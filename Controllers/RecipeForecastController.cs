using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ingredientsNrecipesApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ingredientsNrecipesApi.Services;

namespace ingredientsNrecipesApi.Controllers
{
    [ApiController]
    [Route("/lunch")]
    public class RecipeForecastController : ControllerBase
    {
        private readonly ILogger<RecipeForecastController> _logger;
        private readonly IRecipeService _recipeService;
        public RecipeForecastController(ILogger<RecipeForecastController> logger, IRecipeService recipeService)
        {
            _logger = logger;
            _recipeService=recipeService;
        }
        [HttpPost]
        public ActionResult<IEnumerable<RecipeItem>> Post(RecipeForecastRequest request)   //RecipeForecastRequest request
        {
            IEnumerable<RecipeItem> response = _recipeService.GetLunchRecipies(request);
            return Ok(response);
        }
    }
}
