using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
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
        public string BookingReference { get; set; } = string.Empty; //System Generated

        [Display(Name = "Booking Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }


        [Display(Name = "FPT Site")]
        public int FPTSiteId { get; set; }

        [Required]
        [ForeignKey("FPTSiteId")]
        public  FPTSites FPTSites { get; set; }

        
        [Display(Name = "Vessel")]
        public int VesselId { get; set; }

        [Required]
        [ForeignKey("VesselId")]
        public   Vessels Vessels { get; set; }

      
        [Display(Name = "Logistical Transport")]
        public int LogisticalTransporterId { get; set; }

        [Required]
        [ForeignKey("LogisticalTransporterId")]
        public  LogisticalTransporter LogisticalTransporter { get; set; }

        [Required]
        [RegularExpression(@"^(?![\W_]+$)(?!\d+$)[a-zA-Z0-9]+$", ErrorMessage = "Please enter a valid Registration(remove spaces & special characters if any).")]
        [Remote(action: "IsRegistrationExist", controller: "GCBookings", AdditionalFields = "Id", ErrorMessage = "Registration Invalid ")]
        public string Registration { get; set; } = string.Empty;
        //public string TrailerRegistration { get; set; } = string.Empty; 
        public int Quantity { get; set; }

        [Display(Name = "Commodity")]
        public int CommodityId { get; set; }  // Coils , Cement , Rebar

        [Required]
        [ForeignKey("CommodityId")] 
        public  Commodity Commodity { get; set; }

        [Display(Name = "Name")]
        [RegularExpression(@"^[a-zA-Z ']+$", ErrorMessage = "Use letters only please")]
        public string Name { get; set; } = string.Empty; // Auto-User Name

        [Display(Name = "Phone Number")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Phone Number.")]
        public string PhoneNumber { get; set; } = string.Empty; // Auto-Phone Number

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty; // Auto-User Email

        [Display(Name = "Booking Created On")]
        public DateTime CreatedOn { get; set; }// Booking Creation Date

        [Required]
        [Display(Name ="Time Selected")]
        public string Time { get; set; } = string.Empty;

        public string CreatedBy { get; set; } = string.Empty;// Booking Creation By

        [Display(Name = "Comments")]
        [DataType(DataType.MultilineText)]
        public string? Comments { get; set; }

        [Required]
        [Display(Name = "Import / Export")]
        public string Trade { get; set; } = string.Empty;

    }
}
