using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBooking.Models
{
    public class Flight
    {
        [Display(Name = "Flight Number")]
        public string FlightID { get; set; }
        public string Departure { get; set; }
        public string Destination{ get; set; }
        [Display(Name = "Departure Date")]
        public DateTime DDate { get; set; }
        [Display(Name = "Flight Hour")]
        public string FHour { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
