using System.Collections.Generic;

namespace BrewLib.Models
{
    public interface IRecipeFermentable
    {
        double Amount { get; set; }
        Fermentable Fermentable { get; }
        
    }

    public interface IRecipe
    {
        List<IRecipeFermentable> Fermentables { get; }
        IEquipmentProfile EquipmentProfile { get; }
    }
}