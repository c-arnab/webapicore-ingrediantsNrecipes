using System;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace ingredientsNrecipesApi.Models
{
    public class IngredientItem
    {
        public String title { get; set; }
        [JsonPropertyName("best-before")]
        public DateTime  bestBefore { get; set; }
        [JsonPropertyName("use-by")]       
        public DateTime  useBy { get; set; }
    }
}