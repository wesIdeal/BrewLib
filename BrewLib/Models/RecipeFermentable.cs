namespace BrewLib.Models
{
    public class RecipeFermentable : IRecipeFermentable
    {
        public RecipeFermentable(Fermentable fermentable, double amount)
        {
            Fermentable = fermentable;
            Amount = amount;
        }

        public Fermentable Fermentable { get; }
        public double Amount { get; set; }
    }
}