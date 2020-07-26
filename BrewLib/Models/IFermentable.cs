using System;
using System.Collections.Generic;
using System.Text;

namespace BrewLib.Models
{

    public interface IFermentable
    {
        string Name { get; set; }
        Color Color { get; set; }
    }
}
