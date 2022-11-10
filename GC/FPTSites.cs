using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralCargoSystem.Models.GC
{
    public class FPTSites
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Warehouse")]
        public string SiteLocation { get; set; } = string.Empty;

        [Required]
        public int NumberOfTimeSlots { get; set; }

        [Required]
        [Display(Name = "Location ID")]
        public string LocationId { get; set; } = string.Empty;

    }
}
