using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aflevering1_Avanceret.Models
{
    public class Task
    {
        public int Id { get; set; }
        [Display(Name = "Vare")]
        public string TaskName { get; set; }
        [Display(Name = "Placering")]
        public Locations Location { get; set; }
        [Display(Name = "Antal")]
        public int Quantity { get; set; }
        [Display(Name = "Enhed")]
        public Units Unit { get; set; }
        [Display(Name = "Udført")]
        public bool IsComplete { get; set; }
            
    }
}
