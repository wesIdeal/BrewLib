using System;
using System.Linq;
using BrewLib.Models;

namespace BrewLib
{
    public static class RecipeHelpers
    {
        private const double MoreyConstant = 1.4922;
        private const double MoreyColorUnitExp = 0.6859;
        public static Color RecipeColor(this Recipe recipe)
        {
            var mcuSum = recipe.RecipeMoreyColorUnitSum();
            var mcuWeight = Math.Pow(mcuSum, MoreyColorUnitExp);
            var calculatedSRM = MoreyConstant * mcuWeight;
            return (Color)(Math.Round(calculatedSRM, 1));
        }

        public static double RecipeMoreyColorUnitSum(this IRecipe recipe)
        {
            return recipe.Fermentables.Sum(x => x.RecipeMoreyColorUnit(recipe.EquipmentProfile.PostBoilVolume));
        }

        public static double RecipeMoreyColorUnit(this IRecipeFermentable recipeFermentable, double recipePostBoilVolume)
        {

            return (recipeFermentable.Fermentable.Color * recipeFermentable.Amount) / recipePostBoilVolume;
        }
    }
}
