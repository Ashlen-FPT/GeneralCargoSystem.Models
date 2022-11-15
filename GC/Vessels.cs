using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

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
        [Remote(action: "IsVesselNameExist", controller: "Vessels",AdditionalFields ="Id", ErrorMessage = "Vessel Exists !")]
        public string VesselName { get; set; } = string.Empty;

        [Display(Name = "Vessel No.")]
        [Remote(action: "IsVesselNoExist", controller: "Vessels", AdditionalFields = "Id", ErrorMessage = "Vessel Number Exists !")]
        public string? VesselNo { get; set; }

        [Required]
        [Display(Name = "Voyage No.")]
        [Remote(action: "IsVoyageNoExist", controller: "Vessels", AdditionalFields = "Id", ErrorMessage = "Voyage Number Exists !")]
        public string VoyageNo { get; set; } = string.Empty;

        [Display(Name = "Is Vessel Active")]
        public bool IsActive { get; set; }
    }
}
