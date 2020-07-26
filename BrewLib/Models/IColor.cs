namespace BrewLib.Models
{
    public interface IColor
    {
        double SRM { get; }
        double EBC { get; set; }
        double Lovibond { get; set; }
        string ToString();
    }
}