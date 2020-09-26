using System.Collections.Generic;
using System.Threading.Tasks;
using ingredientsNrecipesApi.Models;

namespace ingredientsNrecipesApi.Services
{
    public interface IRecipeService
    {
        IEnumerable<RecipeItem> GetLunchRecipies(RecipeForecastRequest request);
        
    }
}