using Microsoft.AspNetCore.Mvc;
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
        [Remote(action: "IsFPTSiteExist", controller: "FPTSites", AdditionalFields = "Id", ErrorMessage = "FPT Site Exists !")]
        public string SiteLocation { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Location ID")]
        [Remote(action: "IsLocationIdExist", controller: "FPTSites", AdditionalFields = "Id", ErrorMessage = "Location ID Exists !")]
        public string LocationId { get; set; } = string.Empty;

    }
}
