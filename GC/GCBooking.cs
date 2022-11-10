using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralCargoSystem.Models.GC
{
    public class GCBooking
    {
        public int Id { get; set; }

        public string BookingReference { get; set; } = string.Empty;
        public DateTime Date { get; set; }

        [Required]
        public int FPTSiteId { get; set; }

        [ForeignKey("FPTSiteId")]
        public FPTSites FPTSites { get; set; }

        public int VesselId { get; set; }

        [Required]
        public int LogisticalTransporterId { get; set; }

        [ForeignKey("LogisticalTransporterId")]
        public LogisticalTransporter LogisticalTransporter { get; set; }

        public string Registration { get; set; } = string.Empty;
        public string TrailerRegistration { get; set; } = string.Empty; 
        public int Quantity { get; set; }
        public string CommodityItemId { get; set; }  // Coils , Cement , Rebar
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Time { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }


    }
}
