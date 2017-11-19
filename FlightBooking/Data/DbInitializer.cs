using FlightBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBooking.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any passangers.
            if (context.Flights.Any())
            {
                return;   // DB has been seeded
            }

            /*var passangers= new Passenger[]
            {
                new Passenger{Name="Carson", Age=23, Gender="Male"},
                new Passenger{Name="Meredith", Age=21, Gender="Male"},
                new Passenger{Name="Arturo", Age=30, Gender="Male"},
                new Passenger{Name="Gytis", Age=32, Gender="Male"},
                new Passenger{Name="Yan", Age=22, Gender="Male"},
                new Passenger{Name="Peggy", Age=25, Gender="Female"},
                new Passenger{Name="Laura", Age=28, Gender="Female"},
                new Passenger{Name="Nino", Age=22, Gender="Female"}
            };
            foreach (Passenger s in passangers)
            {
                context.Passangers.Add(s);
            }
            context.SaveChanges();*/

            var flights = new Flight[]
            {
            new Flight{FlightID="LCA1050LON",Departure="Larnaca",Destination="London",DDate=DateTime.Parse("2017-11-12"),FHour="5 Hours 50 Minutes"},
            new Flight{FlightID="CRL4022IEV",Departure="Brussels",Destination="Kiev",DDate=DateTime.Parse("2017-11-24"),FHour="2 Hours 45 Minutes"},
            new Flight{FlightID="LON4041IST",Departure="London",Destination="Istanbul",DDate=DateTime.Parse("2017-12-18"),FHour="3 Hours 55 Minutes"},
            new Flight{FlightID="TBS1045BCN",Departure="Tbilisi",Destination="Barcelona",DDate=DateTime.Parse("2017-11-26"),FHour= "8 Hours 5 Minutes"},
            new Flight{FlightID="IKA3141AMS",Departure="Tehran",Destination="Amsterdam",DDate=DateTime.Parse("2017-11-14"),FHour= "5 Hours 3 Minutes"},
            new Flight{FlightID="HEL2021DXB",Departure="Helsinki",Destination="Dubai",DDate=DateTime.Parse("2017-12-22"),FHour= "11 Hours"},
            new Flight{FlightID="MXP2042BXB",Departure="Milan",Destination="Dubai",DDate=DateTime.Parse("2017-11-22"),FHour= "8 Hours 55 Minutes"}
            };
            foreach (Flight c in flights)
            {
                context.Flights.Add(c);
            }
            context.SaveChanges();

            /*var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }*/
            context.SaveChanges();
        }
    }
}
