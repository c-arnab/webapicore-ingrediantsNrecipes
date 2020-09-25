using System;
using System.Collections.Generic;

namespace ingredientsNrecipesApi.Models
{
    public class RecipeForecastRequest
    {
    public List<IngredientItem> ingredients { get; set; }
    public List<RecipeItem> recipes { get; set; }
    }
}