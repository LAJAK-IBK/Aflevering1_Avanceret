using System.ComponentModel.DataAnnotations;

namespace Aflevering1_Avanceret.Models
{
    public enum Locations
    {
        [Display(Name = "Frugt og grønt")]
        Frugtoggrønt,
                Mejeri,
                Brød,
                Konserves,
                Frost
    }
}
