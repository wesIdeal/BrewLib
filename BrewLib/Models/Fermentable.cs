namespace BrewLib.Models
{
    public class Fermentable : IFermentable
    {
        public Fermentable(string name, Color color)
        {
            Name = name;
            Color = color;
        }

        public string Name { get; set; }
        public Color Color { get; set; }
    }
}