using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GeneralCargoSystem.Models.GC
{
    public class Vessels
    {
        public int Id { get; set; }


        [Required]
        [Display(Name ="Vessel")]
        public string VesselName { get; set; } = string.Empty;
    }
}
