using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using FiledRecipes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiledRecipes.Views
{
    /// <summary>
    /// 
    /// </summary>
    public class RecipeView : ViewBase, IRecipeView
    {
        
    
        public void Show(IRecipe recipe)
        {
            //Show Header
            Header = recipe.Name;
            ShowHeaderPanel();
            
            //Makes a gap between header and ingredients.
            Console.WriteLine();
            Console.WriteLine("Ingredienser");
            Console.WriteLine("------------");
            Console.WriteLine();
            //Write out Ingredients
            foreach (Ingredient showIngredients in recipe.Ingredients)
            {
                Console.WriteLine(showIngredients);
            }
            //Gap and write out intructionts.
            Console.WriteLine();
            Console.WriteLine("Instruktioner");
            Console.WriteLine("-------------");
            
            foreach (string showInstruction in recipe.Instructions)
            {
                Console.WriteLine(showInstruction);
            }
        }

        public void Show(IEnumerable<IRecipe> recipes)
        {
            foreach (var showAllRecipes in recipes)
            {
            Show(showAllRecipes);
            ContinueOnKeyPressed();
            }
            
                
        }
        
        }
}
