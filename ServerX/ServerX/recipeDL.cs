using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
namespace ServerX
{
    public class recipeDL
    {
        public static List<recipe> recipes = new List<recipe>();

        public static void addRecipe(string title, string author, string date, string url, string desc, List<string> categories)
        {
            recipe new_recipe = new recipe();
            new_recipe.Title = title;
            new_recipe.Author = author;
            new_recipe.Date = date;
            new_recipe.Video_url = url;
            new_recipe.Desc = desc;
            new_recipe.Categories = categories;

            recipes.Add(new_recipe);
        }

        public static void updateRecipe(int index, string title, string author, string date, string url, string desc, List<string> categories)
        {
            recipes[index].Title = title;
            recipes[index].Author = author;
            recipes[index].Date = date;
            recipes[index].Video_url = url;
            recipes[index].Desc = desc;
            recipes[index].Categories = categories;
        }
        public static List<recipe> getRecipes()
        {
            return recipes;
        }

        public static int getRecipeCount()
        {
            return recipes.Count();
        }

        public static recipe getRecipeAT(int index)
        {
            recipe this_recipe = recipes[index];
            return this_recipe;
        }

        public static void deleteRecipe(int index)
        {
            recipes.RemoveAt(index);
        }

        public static recipe getRandomRecipe()
        {
            Random r = new Random();
            int rnd = r.Next(0, recipeDL.recipes.Count() - 1);
            return recipeDL.recipes[rnd];
        }
    }
}