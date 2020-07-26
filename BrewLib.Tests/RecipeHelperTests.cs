using BrewLib.Models;
using NUnit.Framework;

namespace BrewLib.Tests
{
    public class RecipeHelperTests
    {
        private readonly IEquipmentProfile _equipmentProfile = new EquipmentProfile()
        {
            PostBoilVolume = 5
        };

        private Recipe _recipe;
        [SetUp]
        public void Setup()
        {
            _recipe = new Recipe(_equipmentProfile);
            _recipe.Fermentables.Add(new RecipeFermentable(Constants.MarisOtter, 10));
        }

        [Test]
        public void ShouldCalculateColorCorrectlyForOneGrain()
        {
            var expectedColor = (Color)5.1;
            var actualColor = _recipe.RecipeColor();
            Assert.AreEqual(expectedColor, actualColor);
        }

        [Test]
        public void ShouldCalculateColorCorrectlyForMultipleGrains()
        {
            var expectedColor = (Color)8.2;
            _recipe.Fermentables.Add(new RecipeFermentable(Constants.Crystal60, 0.5));
            var actualColor = _recipe.RecipeColor();
            
            Assert.AreEqual(expectedColor, actualColor);
        }
    }
}