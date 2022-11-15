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

        [Display(Name="Booking Reference")]
        public string BookingReference { get; set; } = string.Empty;

        [Display(Name = "Booking Date")]
        public DateTime Date { get; set; }

        [Required]
        public int FPTSiteId { get; set; }

        [ForeignKey("FPTSiteId")]
        public FPTSites FPTSites { get; set; } = new FPTSites();

        [Required]
        public int VesselId { get; set; }

        [Required]
        public int LogisticalTransporterId { get; set; }

        [ForeignKey("LogisticalTransporterId")]
        public LogisticalTransporter LogisticalTransporter { get; set; } = new LogisticalTransporter();

        [Required]
        public string Registration { get; set; } = string.Empty;
        //public string TrailerRegistration { get; set; } = string.Empty; 
        public int Quantity { get; set; }

        public int CommodityId { get; set; }  // Coils , Cement , Rebar
        [ForeignKey("CommodityId")] public Commodity Commodity { get; set; } = new Commodity();

        public string Name { get; set; } = string.Empty; // Auto-User Name
        public string PhoneNumber { get; set; } = string.Empty; // Auto-Phone Number
        public string Email { get; set; } = string.Empty; // Auto-User Email
        public DateTime CreatedOn { get; set; }// Booking Creation

        [Required]
        [Display(Name ="Time Selected")]
        public string Time { get; set; } = string.Empty;

    }
}
