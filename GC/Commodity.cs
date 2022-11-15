using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralCargoSystem.Models.GC
{
    public class Commodity
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Commodity Item")]
        public string CommodityItem { get; set; } = string.Empty;
    }
}
