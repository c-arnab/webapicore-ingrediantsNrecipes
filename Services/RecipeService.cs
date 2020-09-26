using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ingredientsNrecipesApi.Models;
using System.Linq;

namespace ingredientsNrecipesApi.Services
{
    public class RecipeService :IRecipeService
    {
        public IEnumerable<RecipeItem> GetLunchRecipies(RecipeForecastRequest request)
        {
            List<RecipeItem> reqRecipes = request.recipes;
            List<IngredientItem> reqIngredients= request.ingredients;

            List<RecipeItem> toprecipes= new List<RecipeItem>();
            List<RecipeItem> botrecipes= new List<RecipeItem>();
            DateTime todaysDate = DateTime.Today;
            foreach (var item in reqRecipes) { 
                bool can_use_recipe=true;
                bool top_recipe=true;
                foreach (var rec_ingr in item.ingredients) {
                    if (can_use_recipe==true) {
                        if (!reqIngredients.Any(z=>z.title==rec_ingr)){
                            can_use_recipe=false;
                        }else{
                            IngredientItem selected_ingredient=  reqIngredients.Find(x => x.title==rec_ingr );  
                            if (selected_ingredient.useBy<todaysDate){
                               can_use_recipe=false;     
                            }else{
                                if(top_recipe==true){
                                    if (selected_ingredient.bestBefore<todaysDate){
                                        top_recipe=false;
                                    }
                                }
                            }
                        }
                    }
                }
                if (can_use_recipe==true) {
                   if(top_recipe==true){
                       toprecipes.Add(item);
                   }else{
                       botrecipes.Add(item);
                   }  
                }
                     
            }
                return toprecipes.Concat(botrecipes);
        }
        
    }
}