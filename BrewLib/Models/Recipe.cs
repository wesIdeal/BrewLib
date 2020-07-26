using System.Collections.Generic;

namespace BrewLib.Models
{
    public interface IEquipmentProfile
    {
        double PostBoilVolume { get; set; }
    }

    public class Recipe : IRecipe
    {
        public Recipe(IEquipmentProfile equipmentProfile)
        {
            EquipmentProfile = equipmentProfile;
            Fermentables = new List<IRecipeFermentable>();
        }
        public IEquipmentProfile EquipmentProfile { get; set; }
        public List<IRecipeFermentable> Fermentables { get; }
    }
}