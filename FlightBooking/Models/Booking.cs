using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBooking.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        [Display(Name = "Booking Date")]
        public DateTime BookingDate { get; set; }
        public Flight Flight { get; set; }
        public Passenger Passenger { get; set; }
        public ApplicationUser User { get; set; }
    }
}
