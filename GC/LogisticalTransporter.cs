using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralCargoSystem.Models.GC
{
    public class LogisticalTransporter
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Transporter")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Transporter Registration")]
        public string RegistrationNo { get; set; } = string.Empty;
    }
}
