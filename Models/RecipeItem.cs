using System;

namespace ingredientsNrecipesApi.Models
{
    public class RecipeItem
    {
        public String title { get; set; }

        public String[] ingredients { get; set; }
    }
}