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
        public Vessels()
        {
            IsActive = true;
        }

        public int Id { get; set; }


        [Required]
        [Display(Name ="Vessel")]
        public string VesselName { get; set; } = string.Empty;

        [Display(Name = "Vessel No.")]
        public string? VesselNo { get; set; }

        [Required]
        [Display(Name = "Voyage No.")]
        public string VoyageNo { get; set; } = string.Empty;

        [Display(Name = "Is Vessel Active")]
        public bool IsActive { get; set; }
    }
}
